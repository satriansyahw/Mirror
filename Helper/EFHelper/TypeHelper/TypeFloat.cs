using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeFloat : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Double;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue =isNull ? (Nullable<float>)0: (float)0;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<float>>) : typeof(List<float>);
            else
                t = isNull ? typeof(Nullable<float>) : typeof(float);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<float>).GetMethod("Contains", new[] { typeof(Nullable<float>) })
                : t = typeof(List<float>).GetMethod("Contains", new[] { typeof(float) });
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
                        var t = new List<Nullable<double>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDouble(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<double>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDouble(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new double();
                    myValue = value.Trim().ToLower();
                    t = Convert.ToDouble(myValue);
                    result = t;
                }

            }
            return result;

        }

        public bool IsActuallyNullData(object value)
        {
            if (value == null) return true;
            if ((float)value == (float)this.GetActuallyNullValue(false)) return true;
            return false;

        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (float)-3.402823e38;
        }
    }
}
