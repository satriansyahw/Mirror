using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeBool : InterfaceType
    {       
        public object GetActuallyNullValue(bool isNull)
        {
            if (isNull) return null;
            return (Boolean)false;
        }

        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Boolean;
        }

        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if(isInOperator)
                t = isNull ? typeof(List<Nullable<bool>>) : typeof(List<bool>);
            else
                t = isNull ? typeof(Nullable<bool>) : typeof(bool);

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
                    if(isNull)
                    {
                        var t = new List<Nullable<bool>>();
                        foreach (var item in value.Split('|'))
                        {
                            
                            myValue = ColumnProperties.GetInstance.IsColumn(item.Trim().ToLower(), "1", "true") ? "true" : "false";
                            t.Add(Convert.ToBoolean(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<bool>();
                        foreach (var item in value.Split('|'))
                        {
                        
                            myValue = ColumnProperties.GetInstance.IsColumn(item.Trim().ToLower(), "1", "true") ? "true" : "false";
                            t.Add(Convert.ToBoolean(myValue));
                        }
                        result = t;
                    }                  
                    
                }
                else
                {
                    var t = new bool();
                    myValue = ColumnProperties.GetInstance.IsColumn(value.Trim().ToLower(), "1", "true") ? "true" : "false";
                    t= Convert.ToBoolean(myValue);
                    result = t;
                }

            }
            return result;

        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
            defaultValue =isNull ? (Nullable<bool>)true: (bool)true;
            return defaultValue;
        }

        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<bool>).GetMethod("Contains", new[] { typeof(Nullable<bool>) }) : t = typeof(List<bool>).GetMethod("Contains", new[] { typeof(bool) });
            return t;           
        }

        public bool IsActuallyNullData(object value)
        {
            // ubah kode ini
            //if (value == null) return true;
            //if ((bool)value == (bool)this.GetActuallyNullValue(false)) return true;
            //return false;


            if (value == null) return true;
            //if ((bool)value == (bool)this.GetActuallyNullValue(false)) return true;
            return false;
        }
    }
}
