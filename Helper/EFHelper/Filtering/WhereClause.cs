using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using EFHelper.ColumnHelper;
using EFHelper.Ekspression;

namespace EFHelper.Filtering
{
    public class WhereClause : InterfaceWhere
    {
       
        public Expression<Func<T, bool>> GetWhereClause<T>(List<SearchField> SearchFieldList) 
        {
            Expression<Func<T, bool>> resultExpr = null;
            if (SearchFieldList != null)
            {
                ParameterExpression pe = Expression.Parameter(typeof(T), typeof(T).Name);              
                SearchFieldList.RemoveAll(a => a.Name == null);//clearingSearchFieldList

                /*trying to add activebool*/
                var activeBoolProp = ColumnPropGet.GetInstance.GetColumnProps(typeof(T), "activebool");
                if(activeBoolProp == null)
                    activeBoolProp = ColumnPropGet.GetInstance.GetColumnProps(typeof(T), "boolactive");
                if(activeBoolProp !=null)
                {
                    if (SearchFieldList.Where(a => a.Name.Trim().ToLower() == activeBoolProp.Name.Trim().ToLower()).ToList().Count <= 0)
                    {
                        SearchFieldList.Add(new SearchField { Name = activeBoolProp.Name, Operator = "=", Value = "true" });
                    }
                }

                Expression combinedExpr = GetWhereClauseProses<T>(pe, SearchFieldList);
                if (combinedExpr != null)
                {
                    resultExpr = Expression.Lambda<Func<T, Boolean>>(combinedExpr, new ParameterExpression[] { pe });
                }
            }
            return resultExpr;
        }
        public Expression<Func<T, bool>> GetWhereClauseDirty<T>(List<SearchField> SearchFieldList)
        {
            Expression<Func<T, bool>> resultExpr = null;
            if (SearchFieldList != null)
            {
                ParameterExpression pe = Expression.Parameter(typeof(T), typeof(T).Name);               
                SearchFieldList.RemoveAll(a => a.Name == null);//clearingSearchFieldList
                Expression combinedExpr = GetWhereClauseProses<T>(pe, SearchFieldList);
                if (combinedExpr != null)
                {
                    resultExpr = Expression.Lambda<Func<T, Boolean>>(combinedExpr, new ParameterExpression[] { pe });
                }
            }
            return resultExpr;
        }
        private Expression GetWhereClauseProses<T>(ParameterExpression pe, List<SearchField> SearchFieldList)
        {
            Expression combinedExpr = null;
            Expression e1 = null;
            Expression columnNameExpr = null;
            Expression columnValueExpr = null;
            string fieldType = string.Empty;
            string fieldName = string.Empty;
            string fullName = string.Empty;
            string colName = string.Empty;
            string colOperator = string.Empty;
            object colValue = null;
            bool isNull = false;
            SearchFieldList = SearchFieldList.Distinct().ToList();//clearing SearchFieldList
            //SearchFieldList.Where(a => a.Operator.Trim().ToLower() == "like").ToList().ForEach(a => a.Value = "%" + a.Value.ToString() + "%");
            SearchFieldList.Where(a => a.Operator.Trim().ToLower() == "like").Select(a => a.Value = "%" + a.Value.ToString() + "%");
            foreach (SearchField itemSearch in SearchFieldList)
            {
                e1 = null;
                columnNameExpr = null;
                columnValueExpr = null;
                fieldType = string.Empty;
                fieldName = string.Empty;
                fullName = string.Empty;
                isNull = false;
                colName = itemSearch.Name;
                colOperator = itemSearch.Operator;
                if (!string.IsNullOrEmpty(colName) & !string.IsNullOrEmpty(colOperator) & itemSearch.Value !=null)
                {
                    colName = colName.Trim().ToLower();
                    colOperator = colOperator.Trim().ToLower();
                    colValue = itemSearch.Value.ToString().Trim().ToLower();

                    var colProp = ColumnPropGet.GetInstance.GetColumnProps(typeof(T), colName);
                    if (colProp != null)//Check if colname exists in Table
                    {
                        columnNameExpr = Expression.Property(pe, colName);
                        columnValueExpr = Expression.Constant(colValue);
                        fieldType = colProp.PropertyType.Name.ToLower();
                        fullName = colProp.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                        fieldName = ColumnProperties.GetInstance.GetClearFieldName(colProp.Name);
                        isNull = ColumnProperties.GetInstance.IsNullableField(fieldType);
                        fieldType = ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName);
                        string myOperator = fieldType == "datetime" ? "datetime" : colOperator;
                        e1 = ExpressionBantuan.GetInstance.DictOperatorExpr[myOperator].GetExpression(isNull, fieldType, colOperator, columnNameExpr, columnValueExpr);

                        if (e1 != null)
                        {
                            if (combinedExpr == null)
                            {
                                combinedExpr = e1;
                            }
                            else
                            {
                                combinedExpr = Expression.And(combinedExpr, e1);
                            }
                        }
                    }

                }
            }

            return combinedExpr;
        }
    }
}
