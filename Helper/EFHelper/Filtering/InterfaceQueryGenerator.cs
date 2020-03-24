using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFHelper.Filtering
{
    public interface InterfaceQueryGenerator
    {
        IQueryable<T> QueryGeneratorList<T>(IQueryable<T> queryable, List<SearchField> SearchFieldList, string sortColumn, bool isascending = false, int toptake = 100);
        IQueryable<TResult> QueryGeneratorList<TSource, TResult>(IQueryable<TSource> queryable, List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where TSource : class where TResult : class; 
       

    }

}
