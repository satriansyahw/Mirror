using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeInt64 : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Int64;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue =isNull ? (Nullable<Int64>)0: (Int64)0;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<Int64>>) : typeof(List<Int64>);
            else
                t = isNull ? typeof(Nullable<Int64>) : typeof(Int64);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<Int64>).GetMethod("Contains", new[] { typeof(Nullable<Int64>) })
                : t = typeof(List<Int64>).GetMethod("Contains", new[] { typeof(Int64) });
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
                        var t = new List<Nullable<Int64>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToInt64(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<Int64>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToInt64(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new Int64();
                    myValue = value.Trim().ToLower();
                    t = Convert.ToInt64(myValue);
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {
            if (value == null) return true;
            if ((Int64)value == (Int64)this.GetActuallyNullValue(false)) return true;
            return false;

        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (Int64)(-9223372036854775808);
        }
    }
}
