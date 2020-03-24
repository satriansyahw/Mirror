using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeGuid : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Guid;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue = isNull ? (Nullable<Guid>)new Guid(): new Guid(); 
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<Guid>>) : typeof(List<Guid>);
            else
                t = isNull ? typeof(Nullable<Guid>) : typeof(Guid);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<Guid>).GetMethod("Contains", new[] { typeof(Nullable<Guid>) })
                : t = typeof(List<Guid>).GetMethod("Contains", new[] { typeof(Guid) });
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
            if ((Guid)value == (Guid)this.GetActuallyNullValue(false)) return true;
            return false;

        }

        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return Guid.Empty;
        }
    }
}
