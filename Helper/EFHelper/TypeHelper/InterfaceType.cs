using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public interface InterfaceType
    {
        object GetDefaultValue(bool isNull);
        DbType GetConvertedDbType(string fieldType);
        Type GetConvertedType(bool isNull, bool isInOperator);
        MethodInfo GetInMethodInfo(bool isNull);
        object GetConvertedValue(bool isNull, object values, string whereOperator);
        bool IsActuallyNullData(object value);
        object GetActuallyNullValue(bool isNull);

    }
}
