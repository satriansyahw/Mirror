using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GenHelper.Props
{
    public class PropHelper
    {
        public PropHelper()
        {

        }
        private static PropHelper instance;
        public static PropHelper GetInstance
        {
            get
            {
                if (instance == null) instance = new PropHelper();
                return instance;
            }
        }
        public void CopyPropertiesTo<T, TU>(T source, TU dest)
        {
            foreach (var property in source.GetType().GetRuntimeProperties())
            {
                if (!string.IsNullOrEmpty(property.Name))
                {
                    if (property.Name.Trim() != "getInstance")
                    {
                        PropertyInfo propertyS = dest.GetType().GetRuntimeProperty(property.Name);
                        if (propertyS != null)
                        {
                            if (propertyS.CanWrite)
                            {
                                var value = property.GetValue(source, null);
                                propertyS.SetValue(dest, property.GetValue(source, null), null);
                            }
                        }
                    }
                }
            }
        }
        public TU CopyPropertiesTo<T, TU>(T source)
        {
            TU dest = Activator.CreateInstance<TU>();
            foreach (var property in source.GetType().GetRuntimeProperties())
            {
                if (!string.IsNullOrEmpty(property.Name))
                {
                    if (property.Name.Trim() != "getInstance")
                    {
                        PropertyInfo propertyS = dest.GetType().GetRuntimeProperty(property.Name);
                        if (propertyS != null)
                        {
                            if (propertyS.CanWrite)
                            {
                                var value = property.GetValue(source, null);
                                propertyS.SetValue(dest, property.GetValue(source, null), null);
                            }
                        }
                    }
                }
            }
            return dest;
        }
        public List<TU> CopyPropertiesTo<T, TU>(List<T> sumber)
        {
            List<TU> listDest = new List<TU>();
            foreach (var source in sumber)
            {
                TU dest = Activator.CreateInstance<TU>();
                foreach (var property in source.GetType().GetRuntimeProperties())
                {
                    if (!string.IsNullOrEmpty(property.Name))
                    {
                        if (property.Name.Trim() != "getInstance")
                        {
                            PropertyInfo propertyS = dest.GetType().GetRuntimeProperty(property.Name);
                            if (propertyS != null)
                            {
                                if (propertyS.CanWrite)
                                {
                                    var value = property.GetValue(source, null);
                                    propertyS.SetValue(dest, property.GetValue(source, null), null);
                                }
                            }
                        }
                    }
                }
                listDest.Add(dest);
            }


            return listDest;
        }
    }
}
