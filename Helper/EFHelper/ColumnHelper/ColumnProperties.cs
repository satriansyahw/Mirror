using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EFHelper.ColumnHelper
{
    public class ColumnProperties
    {
        private static ColumnProperties instance;
        public static ColumnProperties GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ColumnProperties();
                return instance;
            }
        }

        public bool IsColumn(string col, params string[] names) => names.Any(n => n == col);
        public string NullAbleInfo = "nullable`1";
        public string GetClearFieldName(string fieldName)
        {
            return fieldName.Trim().ToLower().Replace("_", "").Replace("<", string.Empty).Replace(">k__BackingField", string.Empty);
        }
        public string ReplaceFieldSystemNullType(string fullName)
        {
            return fullName.Replace("system." + NullAbleInfo + "[[", string.Empty).Replace("system.", string.Empty);
        }
        public bool IsNullableField(string fieldTypeName)
        {
            if (fieldTypeName.Contains(ColumnProperties.GetInstance.NullAbleInfo)) return true;
            return false;
        }
    }
}
