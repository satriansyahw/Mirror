using EFHelper.Filtering;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EFHelper.DBCommandList
{
    public class DBCommandBetweenOperator
    {
        private const string myValue1 = "Value1";
        private const string myValue2 = "Value2";
        public string CreateBetweenWhereClause(SearchField searchField, string fieldType)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(searchField.Operator) & !string.IsNullOrEmpty(searchField.Name) & searchField.Value != null)
            {
                string queryOperator = searchField.Operator.Trim().ToLower();
                if (queryOperator == "between")
                {
                    string valueBetween = searchField.Value.ToString().Replace(@"""", "").Replace(@"'", "").Trim();
                    string value1Parameter = searchField.Name + myValue1;
                    string value2Parameter = searchField.Name + myValue1;
                    if (valueBetween.Contains("|"))
                    {
                        result = searchField.Name + " between " + "@" + value1Parameter + " and " + "@" + value2Parameter;
                    }
                    else
                    {
                        result = searchField.Name + "=" + "@" + value1Parameter;
                    }
                }
            }                  
            return result;
        }        
        public List<SqlParameter> CreateBetweenParameter(SearchField searchField, string fieldType)
        {
            List<SqlParameter> result = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(searchField.Operator) & !string.IsNullOrEmpty(searchField.Name) & searchField.Value != null)
            {
                string queryOperator = searchField.Operator.Trim().ToLower();
                if (queryOperator == "between")
                {
                    string valueBetween = searchField.Value.ToString().Replace(@"""", "").Replace(@"'", "").Trim();
                    string value1 = string.Empty;
                    string value2 = string.Empty;
                    string value1Parameter = searchField.Name + myValue1;
                    string value2Parameter = searchField.Name + myValue2;
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
                    DbType dbType = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedDbType(fieldType);
                    if (fieldType == "datetime" || valueBetween.Contains("|"))
                    {
                        result.Add(new SqlParameter { ParameterName = "@" + value1Parameter, Value = value1, DbType = dbType });
                        result.Add(new SqlParameter { ParameterName = "@" + value2Parameter, Value = value2, DbType = dbType });
                    }
                    else
                    {
                        result.Add(new SqlParameter { ParameterName = "@" + value1Parameter, Value = value1, DbType = dbType });
                    }
                }
            }
            return result;
        }

    }
}
