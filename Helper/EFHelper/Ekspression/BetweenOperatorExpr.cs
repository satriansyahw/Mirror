using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EFHelper.Ekspression
{
    public class BetweenOperatorExpr : InterfaceOperatorExpr
    {

        public Expression GetExpression(bool isNull,string fieldType, string whereOperator,Expression columnNameExpr, Expression columnValueExpr)
        {
            Expression combinedExpr = null;
            TypeDatetime typeDatetime = new TypeDatetime();
            if (!string.IsNullOrEmpty(whereOperator) & columnNameExpr != null & columnValueExpr != null)
            {

                string valueBetween = columnValueExpr.ToString().Replace(@"""", "").Replace(@"'","").Trim();
                string value1 = string.Empty;
                string value2=string.Empty;

                object colValue = null;
                InterfaceOperatorExpr expr = null;
                TypeString typeString = new TypeString();

                if (valueBetween.Contains("|"))
                {
                    string[] valueBetweenArray = valueBetween.Split(new char[] { '|' });
                    value1 = valueBetweenArray[0].Trim();
                    value2 = valueBetweenArray[1].Trim();
                    value1 = fieldType == "datetime" ? Convert.ToDateTime(value1).ToString("yyyy-MM-dd") + " " + "00:00:00" : value1;
                    value2 = fieldType == "datetime" ? Convert.ToDateTime(value2).ToString("yyyy-MM-dd") + " " + "23:59:59" : value2;

                }
                else
                {
                    value1 = valueBetween;
                    value1 = fieldType == "datetime" ? Convert.ToDateTime(value1).ToString("yyyy-MM-dd") + " " + "00:00:00" : value1;
                    value2 = fieldType == "datetime" ? Convert.ToDateTime(value1).ToString("yyyy-MM-dd") + " " + "23:59:59" : value1;
                }
                if (fieldType == "datetime")
                {
                    colValue = typeString.GetConvertedValue(false, value1, whereOperator);
                    colValue = fieldType != "datetime" ? colValue : typeDatetime.GetConvertedValue(false, value1, whereOperator);
                    columnValueExpr = Expression.Constant(colValue);
                    expr = new MoreThanOperatorExpr();
                    combinedExpr = expr.GetExpression(false, "datetime", whereOperator, columnNameExpr, columnValueExpr);

                    colValue = typeString.GetConvertedValue(false, value2, whereOperator);
                    colValue = fieldType != "datetime" ? colValue : typeDatetime.GetConvertedValue(false, value2, whereOperator);
                    columnValueExpr = Expression.Constant(colValue);
                    expr = new LessThanOperatorExpr();
                    combinedExpr = Expression.And(combinedExpr, expr.GetExpression(false, "datetime", whereOperator, columnNameExpr, columnValueExpr));
                    //>=2017-01-01 00:00:00 and <= 2017-01-01 23:59:59
                }
                else
                {
                    if (valueBetween.Contains("|"))
                    {
                        colValue = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedValue(isNull, value1, whereOperator);
                        columnValueExpr = Expression.Constant(colValue);
                        expr = new MoreThanOperatorExpr();
                        combinedExpr = expr.GetExpression(false, fieldType, ">=", columnNameExpr, columnValueExpr);

                        colValue = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedValue(isNull, value2, whereOperator);
                        columnValueExpr = Expression.Constant(colValue);
                        expr = new LessThanOperatorExpr();
                        combinedExpr = Expression.And(combinedExpr, expr.GetExpression(false, fieldType, "<", columnNameExpr, columnValueExpr));
                        //fieldname >= 10 and fieldname <12

                    }
                    else
                    {
                        colValue = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedValue(isNull, value1, whereOperator);
                        columnValueExpr = Expression.Constant(colValue);
                        expr = new EqualOperatorExpr();
                        combinedExpr = expr.GetExpression(false, fieldType,"=", columnNameExpr, columnValueExpr);
                        //fieldname = 10 

                    }
                }             

             
            }
            return combinedExpr;
        }

    }
    
}
