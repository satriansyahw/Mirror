using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeShort : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Int16;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue =isNull ? (Nullable<short>)0: (short)0;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<short>>) : typeof(List<short>);
            else
                t = isNull ? typeof(Nullable<short>) : typeof(short);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<short>).GetMethod("Contains", new[] { typeof(Nullable<short>) })
                : t = typeof(List<short>).GetMethod("Contains", new[] { typeof(short) });
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
                        var t = new List<Nullable<short>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToInt16(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<short>();
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
                    var t = new short();
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
            if ((short)value == (short)this.GetActuallyNullValue(false)) return true;
            return false;

        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (Int64)(-32768);
        }
    }
}
