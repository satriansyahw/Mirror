using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EFHelper.Ekspression
{
    public class EqualOperatorExpr : InterfaceOperatorExpr
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
                bool isInOperator = false;
                var type = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedType(isNull, isInOperator);
                var myLeft = Expression.Convert(columnNameExpr, type);
                var myRight = Expression.Convert(columnValueExpr, type);
                result= Expression.Equal(myLeft, myRight);
            }
            return result;
        }
    }
}
