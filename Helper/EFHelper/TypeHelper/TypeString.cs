using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeString : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.String;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue = "";
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<string>) : typeof(List<string>);
            else
                t = isNull ? typeof(string) : typeof(string);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<string>).GetMethod("Contains", new[] { typeof(string) })
                : t = typeof(List<string>).GetMethod("Contains", new[] { typeof(string) });
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
                        var t = new List<string>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToString(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<string>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToString(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = string.Empty;
                    myValue = value.Trim().ToLower();
                    t = Convert.ToString(myValue);
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {
            if (value == null) return true;
            if ((string)value == (string)this.GetActuallyNullValue(false)) return true;
            return false;
        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (string)("~u*^$");
        }
    }
}
