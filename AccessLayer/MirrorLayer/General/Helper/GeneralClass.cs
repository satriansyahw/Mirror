using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MirrorLayer.General.Helper
{
    public class GeneralClass
    {
        private static GeneralClass instance;
        public static GeneralClass GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new GeneralClass();
                return instance;
            }
        }

        public object GetValueObject<T>(string propEntity, object value) where T : class
        {
            object resultValue = null;
            var entity = (T)Activator.CreateInstance(typeof(T));
            foreach (var item in entity.GetType().GetRuntimeProperties())
            {
                if (item.Name.ToLower() == propEntity.ToLower())
                {
                    if (item.PropertyType.Name == "String")
                    {
                        if (value != null)
                            resultValue = GetValue(value.ToString());
                        else
                            resultValue = string.Empty;
                    }
                    else
                    {
                        resultValue = value;
                    }
                    break;
                }
            }
            return resultValue;
        }

        private string GetValue(string propValue)
        {
            string retValue = string.Empty;
            if (propValue != "0")
                retValue = propValue.Trim();
            return retValue;
        }
    }
}
