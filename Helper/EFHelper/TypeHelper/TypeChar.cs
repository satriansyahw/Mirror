using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeChar : InterfaceType
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
                t = isNull ? typeof(List<Nullable<char>>) : typeof(List<char>);
            else
                t = isNull ? typeof(Nullable<char>) : typeof(char);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<char>).GetMethod("Contains", new[] { typeof(Nullable<char>) }) : t = typeof(List<char>).GetMethod("Contains", new[] { typeof(char) });
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
                        var t = new List<Nullable<char>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToChar(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<char>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToChar(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new char();
                    myValue = value.Trim().ToLower();
                    t = Convert.ToChar(myValue);
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {

            if (value == null) return true;
            if ((char)value == (char)this.GetActuallyNullValue(false)) return true;
            return false;
        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (char)'\uffff';
        }
    }
}
