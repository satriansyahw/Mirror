using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EFHelper.Filtering
{
    public class QueryGenerator : InterfaceQueryGenerator
    {
        WhereClause where = new WhereClause();
        OrderByClause order = new OrderByClause();
        public IQueryable<T> QueryGeneratorList<T>(IQueryable<T> queryable, List<SearchField> SearchFieldList, string sortColumn, bool isascending = false, int toptake = 100)
        {
            IQueryable<T> result = null;
            if (queryable != null)
            {
                result = queryable;
                SearchFieldList = SearchFieldList == null ? new List<SearchField>() : SearchFieldList;
                var whereClause = where.GetWhereClause<T>(SearchFieldList);//membuat clause where
                result = whereClause != null ? result.Where(whereClause) : result;// menambahkan clause where
                result = !string.IsNullOrEmpty(sortColumn) ? order.OrderByDynamic<T>(result, sortColumn, isascending) : result;//menambahkan order by
                result = toptake == 0 ? result : result.Take(toptake);//menambahkan top take, if 0 maka all data

            }
            return result;
        }

        public IQueryable<TResult> QueryGeneratorList<TSource, TResult>(IQueryable<TSource> queryable, List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake)
        where TSource : class where TResult:class
        {
            IQueryable<TSource> tSources = null;
            IQueryable<TResult> tResult = null;
            if (queryable != null)
            {
                /*Procesing on TSource*/
                tSources = queryable;
                SearchFieldList = SearchFieldList == null ? new List<SearchField>() : SearchFieldList;
                var whereClause = where.GetWhereClause<TSource>(SearchFieldList);//membuat clause where
                tSources = whereClause != null ? tSources.Where(whereClause) : tSources;// menambahkan clause where
                tSources = !string.IsNullOrEmpty(sortColumn) ? order.OrderByDynamic<TSource>(tSources, sortColumn, isascending) : tSources;//menambahkan order by
                tSources = toptake == 0 ? tSources : tSources.Take(toptake);//menambahkan top take, if 0 maka all data
                Expression<Func<TSource, TResult>> selectedColumnExpr = ColumnPropGet.GetInstance.GetSelectedColumnExpression<TSource, TResult>();
                if (selectedColumnExpr != null)
                {
                    tResult = tSources.Select(selectedColumnExpr);
                }

            }
            return tResult;
        }

        
    }

}
