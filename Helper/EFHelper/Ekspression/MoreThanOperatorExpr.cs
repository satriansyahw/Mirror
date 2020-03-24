using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EFHelper.Ekspression
{
    public class MoreThanOperatorExpr : InterfaceOperatorExpr
    {

        public Expression GetExpression(bool isNull,string fieldType, string whereOperator,Expression columnNameExpr, Expression columnValueExpr)
        {
            columnValueExpr = Expression.Constant( // recreate columnValueExpr
                   TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedValue(isNull,
                   columnValueExpr.ToString().Replace(@"""", "").Replace("'", ""), whereOperator)
                   );
            Expression result = null;
            if (!string.IsNullOrEmpty(whereOperator) & columnNameExpr != null & columnValueExpr != null)
            {
                bool isInOperator = false;
                var type = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedType(isNull, isInOperator);
                var myLeft = Expression.Convert(columnNameExpr, type);
                var myRight = Expression.Convert(columnValueExpr, type);
                if (whereOperator.Trim().ToLower() == ">")
                    result= Expression.GreaterThan(myLeft, myRight);
                else
                    result= Expression.GreaterThanOrEqual(myLeft, myRight);//>=
            }
            return result;

        }
    }
}
