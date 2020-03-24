using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using EFHelper.ColumnHelper;
using EFHelper.Filtering;
using EFHelper.TypeHelper;

namespace EFHelper.DBCommandList
{
    public class DBCommandListGet: InterfaceDBCommandListGet
    {
        private static DBCommandListGet instance;
        private const string select = " select ";
        private const string orderby = " order by ";
        private const string aliasnull = " =null ";
        private const string operatorlike = "like";
        private const string operatorbetween = "between";

        public static DBCommandListGet GetInstance
        {
            get
            {
                if (instance == null) instance = new DBCommandListGet();
                return instance;
            }
        }

       
        public string GetTableName<T>() where T : class
        {
            /*the structre must folder -> file  means folder is schema folder, file is tablename file*/
            string result = string.Empty;
            string defaultSchema = "dbo";
            var myClass = Activator.CreateInstance<T>();
            string className = myClass.ToString();
            if (!className.Contains("."))
                result = defaultSchema + "." + className;
            else
            {
                string[] classNameArray = className.Split(".");
                if (classNameArray.Length >= 2)
                    result = classNameArray[classNameArray.Length - 2] + "." + classNameArray[classNameArray.Length - 1];
                else
                    result = classNameArray[0];

            }
            return result;
        }
        public string GetSelectFields<T>() where T : class
        {
            string result = string.Empty;
            List<ColumnListInfo> columnList = ColumnPropGet.GetInstance.GetColumnList<T>();
            foreach (var columnName in columnList)
            {
                result = !string.IsNullOrEmpty(result) ? result + "," + columnName.ColPropInfo.Name : columnName.ColPropInfo.Name;
            }
            return " " + result + " ";
        }
        public string GetSelectFields<TSource, TResult>() where TSource : class where TResult : class
        {
            string result = string.Empty;
            List<ColumnListInfo> columnListSource = ColumnPropGet.GetInstance.GetColumnList<TSource>();
            List<ColumnListInfo> columnListResult = ColumnPropGet.GetInstance.GetColumnList<TResult>();
            string columnAlias = string.Empty;
            string columnResult = string.Empty;
            foreach (var columnName in columnListResult)
            {
                columnResult = columnName.ColName.Trim().ToLower();
                if (columnListSource.Exists(a => a.ColName.Trim().ToLower() == columnResult))
                {
                    result = !string.IsNullOrEmpty(result) ? result + "," + columnName.ColPropInfo.Name : columnName.ColPropInfo.Name;
                }
                else
                {
                    result = !string.IsNullOrEmpty(result) ? result + "," + columnName.ColPropInfo.Name + aliasnull : columnName.ColPropInfo.Name + aliasnull;
                }

            }
            return " " + result + " ";
        }
        public List<SqlParameter> GetWhereParameterCollection<T>(List<SearchField> lsf) where T : class
        {
            DBCommandBetweenOperator betweenOprt = new DBCommandBetweenOperator();
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            foreach (SearchField item in lsf)
            {
                if (!string.IsNullOrEmpty(item.Name) & !string.IsNullOrEmpty(item.Operator) & item.Value != null)
                {
                    string colName = item.Name.Replace(@"""", "").Replace("'", "").Trim();
                    PropertyInfo colProp = ColumnPropGet.GetInstance.GetColumnProps<T>(colName);
                    if (colProp != null & !string.IsNullOrEmpty(item.Operator) & !string.IsNullOrEmpty(item.Value.ToString()))
                    {
                        string value = item.Value.ToString().Replace("'", "''");
                        string queryOperator = item.Operator.ToLower().Trim();
                        string colType = ColumnPropGet.GetInstance.GetColumnType(colProp);

                        if (colType == "boolean")                       
                            item.Value = item.Value.ToString().Trim().ToLower() == "true" ? true : false;
                        
                        DbType dbType = TypeBantuan.GetInstance.DictTypes[colType].GetConvertedDbType(colType);
                        if (queryOperator == operatorbetween)
                        {
                            var listParameter = betweenOprt.CreateBetweenParameter(item, colType);
                            sqlParameters.AddRange(listParameter);
                        }
                        else
                        {
                            if (queryOperator == operatorlike)
                            {
                                value = string.Format(@"'%" + value + "%'");
                            }
                            var myParams = new SqlParameter
                            {
                                ParameterName = "@" + colProp.Name,
                                Value = item.Value.ToString().Replace("'", "''"),
                                DbType = dbType
                            };
                            if (!sqlParameters.Contains(myParams))
                                sqlParameters.Add(myParams);

                        }
                    }
                }
            }
            return sqlParameters;
        }
        public string GetWhereParameterizedQuery<T>(List<SearchField> lsf) where T : class
        {
            DBCommandBetweenOperator betweenOprt = new DBCommandBetweenOperator();
            string result = " where 1=1 ";
            var activeBoolProp = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool");
            if (activeBoolProp == null)
                activeBoolProp = ColumnPropGet.GetInstance.GetColumnProps<T>("boolactive");
            if (activeBoolProp != null)
            {
                result += " and " + activeBoolProp.Name + " = 1 ";
            }
            foreach (SearchField item in lsf)
            {
                if (!string.IsNullOrEmpty(item.Name) & !string.IsNullOrEmpty(item.Operator) & item.Value != null)
                {
                    string colName = item.Name.Replace(@"""", "").Replace("'", "").Trim();
                    PropertyInfo colProp = ColumnPropGet.GetInstance.GetColumnProps<T>(colName);
                    if (colProp != null)
                    {
                        string colType = ColumnPropGet.GetInstance.GetColumnType(colProp);
                        if (item.Operator == "between")
                            result += " and " + betweenOprt.CreateBetweenWhereClause(item, colType);
                        else
                            result += " and " + colProp.Name + " " + item.Operator + " " + "@" + colProp.Name;
                    }
                }
            }
            return result;
        }
        public string GetOrderBy<T>(string sortColumn, bool isAscending) where T : class
        {
            string result = string.Empty;
            PropertyInfo colProp = ColumnPropGet.GetInstance.GetColumnProps<T>(sortColumn);
            PropertyInfo colIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            if (colProp != null)
            {
                result = isAscending ? " asc " : " desc ";
                result = orderby + colProp + result;
                return result;
            }
            if (colIdentity != null)
            {
                result = isAscending ? " asc " : " desc ";
                result = orderby + colIdentity + result;
                return result;
            }
            return result;
        }
        public string GetTopQuery(int topTake) 
        {
            string result = string.Empty;
            result = topTake == 0 ? string.Empty : " top " + topTake.ToString();
            return " " + result + " ";
        }
    }
}
