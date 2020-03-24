using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EFHelper.Filtering
{
    public interface InterfaceWhere
    {
        Expression<Func<T, Boolean>> GetWhereClause<T>(List<SearchField> SearchFieldList);
        Expression<Func<T, Boolean>> GetWhereClauseDirty<T>(List<SearchField> SearchFieldList);
    }
}
