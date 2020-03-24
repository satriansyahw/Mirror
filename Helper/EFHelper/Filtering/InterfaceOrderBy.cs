using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFHelper.Filtering
{
    public interface InterfaceOrderBy
    {
        IQueryable<T> OrderByDynamic<T>(IQueryable<T> query, string sortColumn, bool isAscending);
    }
}
