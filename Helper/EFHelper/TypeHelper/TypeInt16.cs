using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeInt16 : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Int16;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue =isNull ? (Nullable<Int16>)0: (Int16)0;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<Int16>>) : typeof(List<Int16>);
            else
                t = isNull ? typeof(Nullable<Int16>) : typeof(Int16);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<Int16>).GetMethod("Contains", new[] { typeof(Nullable<Int16>) })
                : t = typeof(List<Int16>).GetMethod("Contains", new[] { typeof(Int16) });
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
                        var t = new List<Nullable<Int16>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToInt16(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<Int16>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToInt16(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new Int16();
                    myValue = value.Trim().ToLower();
                    t = Convert.ToInt16(myValue);
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {
            if (value == null) return true;
            if ((Int16)value == (Int16)this.GetActuallyNullValue(false)) return true;
            return false;

        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (Int16)(-32768);
        }
    }
}
