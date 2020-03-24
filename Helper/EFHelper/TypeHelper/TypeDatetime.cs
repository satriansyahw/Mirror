using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeDatetime : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.DateTime;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue = isNull ? (Nullable<DateTime>)DateTime.Now : (DateTime)DateTime.Now;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<DateTime>>) : typeof(List<DateTime>);
            else
                t = isNull ? typeof(Nullable<DateTime>) : typeof(DateTime);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<DateTime>).GetMethod("Contains", new[] { typeof(Nullable<DateTime>) }) : t = typeof(List<DateTime>).GetMethod("Contains", new[] { typeof(DateTime) });
            return t;
        }
        public object GetConvertedValue(bool isNull, object values, string whereOperator)
        {

            object result = null;
            string value = string.Empty;
            string myValue = string.Empty;
            if (values != null)
            {
                bool isInOperator = false;
                value = values.ToString();
                if (ColumnProperties.GetInstance.IsColumn(whereOperator.Trim().ToLower(), "in", "like","contains") || value.Contains("|"))
                    isInOperator = true;
                if (isInOperator)
                {
                    if (isNull)
                    {
                        var t = new List<Nullable<DateTime>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDateTime(Convert.ToDateTime(item).ToString("yyyy-MM-dd HH:mm:ss")));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<DateTime>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDateTime(Convert.ToDateTime(item).ToString("yyyy-MM-dd HH:mm:ss")));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new DateTime();
                    myValue = value.Trim().ToLower();
                    t =(Convert.ToDateTime(Convert.ToDateTime(myValue).ToString("yyyy-MM-dd HH:mm:ss")));
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {
            if (value == null) return true; 
            int nullDatetime = 1;
            DateTime dateTime = (DateTime)value;
            if (dateTime.Date.Year == nullDatetime)
                return true;
            return false;
        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            DateTime dateTime = new DateTime(1, 1, 1);
            return dateTime;
        }
    }
}
