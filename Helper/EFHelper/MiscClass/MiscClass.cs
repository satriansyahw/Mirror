using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.MiscClass
{
    public class MiscClass
    {
        public enum EnumSaveUpdateDelete
        {
            Save,Update,Delete
        }
        public static string[] ArrayInsertDate = { "insertdate", "inserttime", "inserteddate", "insertedtime" };
        public static string[] ArrayUpdateDate = { "updatedate","updatetime", "updateddate", "updatedtime","lastupdate", "lastupdated" };
        public static string[] ArrayUpdateBy = { "updateby", "picupdate","updatepic" };
        public static string[] ArrayInsertBy = { "insertby", "picinsert","insertpic" };
        public static string[] ArrayActiveBool = { "activebool", "boolactive" };
        public static string[] ArrayDataTypeNullValue = { "short", "ushort", "Int16", "UInt16", "int", "uint", "long", "ulong", "Int64", "UInt64", "Single", "float", "double", "decimal","char","single" };
        public static int CommandTimeOut =100;
        public static bool IsUsingADODBCommandList = false;// if false will be check to actual properties, if true, will authomatically using  IsUsingADODBCommandList
    }
    public class ColumnConvertNoToName
    {
        public string SourceColumnNo { get; set; }
        public string TargetColumnName { get; set; }
    }
    public class ConvertNoToName
    {
        public string ColumnNoValue { get; set; }
        public string ColumnNameValue { get; set; }
    }
    public class ConvertNoToNamePI
    {
        public PropertyInfo SourceNoPropertyInfo { get; set; }
        public PropertyInfo TargetNamePropertyInfo { get; set; }
    }
    public class DataTypeNullValue
    {
        /*never assign your variable to these below data, because your variable will become null, this is only for not null data, that wiil be not assigned to any values*/
        public static short Null_Short { get; }= -32768;
        public static ushort Null_UShort { get; } = 65535;
        public static Int16 Null_Int16 { get; } = -32768;
        public static UInt16 Null_UInt16 { get; } = 65535;
        public static int Null_Int { get; } = -2147483648;
        public static uint Null_UInt { get; } = 4294967295;
        public static long Null_Long { get; } = -9223372036854775808;
        public static ulong Null_ULong { get; } = 18446744073709551615;
        public static Int64 Null_Int64 { get; } = -9223372036854775808;
        public static UInt64 Null_UInt64 { get; } = 18446744073709551615;
        public static Single NullSingle { get; } =(Single)3402823E+38;
        public static float Null_Float { get; } = (float)-3.402823e38;
        public static double Null_Double { get; } = (double)(17976931348623223308);
        public static decimal Null_Decimal { get; } = (decimal)7976931348623223308;
        public static char Null_Char { get; } = (char)'\uffff';
        public static Single Null_Single { get; } = (float)-3.402823e38;
        public static string Null_String { get; } = "~u*^$";

    }

}
