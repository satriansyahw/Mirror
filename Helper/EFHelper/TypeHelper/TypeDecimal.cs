using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeDecimal : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Decimal;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue = isNull ? (Nullable<decimal>)0 : (decimal)0;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<decimal>>) : typeof(List<decimal>);
            else
                t = isNull ? typeof(Nullable<decimal>) : typeof(decimal);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<decimal>).GetMethod("Contains", new[] { typeof(Nullable<decimal>) }) 
                : t = typeof(List<decimal>).GetMethod("Contains", new[] { typeof(decimal) });
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
                        var t = new List<Nullable<decimal>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDecimal(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<decimal>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDecimal(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new decimal();
                    myValue = value.Trim().ToLower();
                    t = Convert.ToDecimal(myValue);
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {
            if (value == null) return true;
            if ((decimal)value == (decimal)this.GetActuallyNullValue(false)) return true;
            return false;

        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (decimal)7976931348623223308;
        }
    }
}
