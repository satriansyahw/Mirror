using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeByte : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Byte;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue = isNull ? (Nullable<byte>)0 : (byte)0;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<byte>>) : typeof(List<byte>);
            else
                t = isNull ? typeof(Nullable<byte>) : typeof(byte);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<byte>).GetMethod("Contains", new[] { typeof(Nullable<byte>) }) : t = typeof(List<byte>).GetMethod("Contains", new[] { typeof(byte) });
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
                        var t = new List<Nullable<byte>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToByte(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<byte>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToByte(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new byte();
                    myValue = value.Trim().ToLower();
                    t = Convert.ToByte(myValue);
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {
            if (value == null) return true;
            if ((byte)value == (byte)this.GetActuallyNullValue(false)) return true;
            return false;
        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (byte)0;
        }
    }
}
