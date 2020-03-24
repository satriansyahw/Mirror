using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EFHelper.Ekspression
{
    public class DatetimeExpr : InterfaceOperatorExpr
    {
        public Expression GetExpression(bool isNull, string fieldType, string whereOperator, Expression columnNameExpr, Expression columnValueExpr)
        {
            Expression combinedExpr = null;
            TypeDatetime typeDatetime = new TypeDatetime();
            if (!string.IsNullOrEmpty(whereOperator) & columnNameExpr != null & columnValueExpr != null)
            {

                string valueDatetime = columnValueExpr.ToString().Replace(@"""", "").Replace(@"'","").Trim();
                DateTime dateTime = Convert.ToDateTime(valueDatetime);
                string mydatefrom = dateTime.ToString("yyyy-MM-dd") + " " + "00:00:00";
                string mydateto = dateTime.ToString("yyyy-MM-dd") + " " + "23:59:59";
                object colValue = null;
                InterfaceOperatorExpr expr = null;
                TypeString typeString = new TypeString();

                if (ColumnProperties.GetInstance.IsColumn(whereOperator, ">", ">=", "<", "<=", "="))
                {
                    if (ColumnProperties.GetInstance.IsColumn(whereOperator, ">", ">="))
                    {
                        colValue = typeString.GetConvertedValue(false, mydatefrom, whereOperator);
                        colValue = fieldType != "datetime" ? colValue : typeDatetime.GetConvertedValue(false, mydatefrom, whereOperator);
                        columnValueExpr = Expression.Constant(colValue);
                        expr = new MoreThanOperatorExpr();
                        combinedExpr = expr.GetExpression(false, "datetime", whereOperator, columnNameExpr, columnValueExpr);
                        //>= 2017-01-01 00:00:00
                    }
                    if (ColumnProperties.GetInstance.IsColumn(whereOperator, "<", "<="))
                    {
                        colValue = typeString.GetConvertedValue(false, mydateto, whereOperator);
                        colValue = fieldType != "datetime" ? colValue : typeDatetime.GetConvertedValue(false, mydateto, whereOperator);
                        columnValueExpr = Expression.Constant(colValue);
                        expr = new LessThanOperatorExpr();
                        combinedExpr = expr.GetExpression(false, "datetime", whereOperator, columnNameExpr, columnValueExpr);
                        //<= 2017-01-01 23:59:59

                    }
                    if (ColumnProperties.GetInstance.IsColumn(whereOperator, "="))
                    {
                        colValue = typeString.GetConvertedValue(false, mydatefrom, whereOperator);
                        colValue = fieldType != "datetime" ? colValue : typeDatetime.GetConvertedValue(false, mydatefrom, whereOperator);
                        columnValueExpr = Expression.Constant(colValue);
                        expr = new MoreThanOperatorExpr();
                        combinedExpr = expr.GetExpression(false, "datetime", whereOperator, columnNameExpr, columnValueExpr);

                        colValue = typeString.GetConvertedValue(false, mydateto, whereOperator);
                        colValue = fieldType != "datetime" ? colValue : typeDatetime.GetConvertedValue(false, mydateto, whereOperator);
                        columnValueExpr = Expression.Constant(colValue);
                        expr = new LessThanOperatorExpr();
                        combinedExpr = Expression.And(combinedExpr, expr.GetExpression(false, "datetime", whereOperator, columnNameExpr, columnValueExpr));
                        //>=2017-01-01 00:00:00 and <= 2017-01-01 23:59:59
                    }
                }
            }
            return combinedExpr;
        }


    }
}
