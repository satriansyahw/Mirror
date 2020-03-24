using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace EFHelper.Filtering
{
    public class OrderByClause : InterfaceOrderBy
    {
        public IQueryable<T> OrderByDynamic<T>(IQueryable<T> query, string sortColumn, bool isAscending)
        {
            if (query != null)
            {
                var parameter = Expression.Parameter(typeof(T), "p");
                var colProp = ColumnPropGet.GetInstance.GetColumnProps(typeof(T), sortColumn);
                colProp = colProp != null ? colProp : ColumnPropGet.GetInstance.GetIdentityColumnProps(typeof(T));//jika tidak ada sort column, coba sort by identity atau column order ke 0

                if (colProp != null)
                {
                    /*Jika kolom sortcolumn ada di table T nya*/
                    string command = "OrderBy";
                    if (!isAscending)
                    {
                        command = "OrderByDescending";
                    }
                    Expression resultExpression = null;                 

                    // var property = typeof(T).GetProperty(sortColumn);
                    // this is the part p.SortColumn
                    var propertyAccess = Expression.MakeMemberAccess(parameter, colProp);

                    // this is the part p =&gt; p.SortColumn
                    var orderByExpression = Expression.Lambda(propertyAccess, parameter);

                    // finally, call the "OrderBy" / "OrderByDescending" method with the order by lamba expression
                    resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { typeof(T), colProp.PropertyType },
                       query.Expression, Expression.Quote(orderByExpression));

                    query = query.Provider.CreateQuery<T>(resultExpression);
                }               
            }
            return query;
        }
    }
}
