using System;
using System.Linq.Expressions;

namespace EFHelper.Ekspression
{
    public interface InterfaceOperatorExpr
    {
        Expression GetExpression(bool isNull, string fieldType, string whereOperator, Expression columnNameExpr, Expression columnValueExpr);
    }

}
