using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EFHelper.Ekspression
{
    public class InOperatorExpr : InterfaceOperatorExpr
    {

        public Expression GetExpression(bool isNull,string fieldType, string whereOperator,Expression columnNameExpr, Expression columnValueExpr)
        {
            Expression result = null;
            if (!string.IsNullOrEmpty(whereOperator) & columnNameExpr != null & columnValueExpr != null)
            {
                columnValueExpr = Expression.Constant( // recreate columnValueExpr
                   TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedValue(isNull,
                   columnValueExpr.ToString().Replace(@"""", "").Replace("'", ""), whereOperator)
                   );
                bool isInOperator = true;
                var type = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedType(isNull, isInOperator);
                var method = TypeBantuan.GetInstance.DictTypes[fieldType].GetInMethodInfo(isNull);
                var myLeft = Expression.Convert(columnValueExpr, type);
                result= Expression.Call(myLeft, method, columnNameExpr);
            }
            return result;
        }
    }
}
