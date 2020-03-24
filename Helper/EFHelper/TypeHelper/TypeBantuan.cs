using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeBantuan
    {
        private static TypeBantuan instance;
        
        public TypeBantuan()
        {
           
            this.LoadInitialType();
        }
        public static TypeBantuan GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new TypeBantuan();
                return instance;
            }
        }
        public Dictionary<string, InterfaceType> DictTypes = new Dictionary<string, InterfaceType>();
        private void LoadInitialType()
        {
            DictTypes.Add("int16", new TypeInt16());
            DictTypes.Add("int32", new TypeInt32());
            DictTypes.Add("int64", new TypeInt64());
            DictTypes.Add("string", new TypeString());
            DictTypes.Add("char", new TypeChar());
            DictTypes.Add("float", new TypeFloat());
            DictTypes.Add("decimal", new TypeDecimal());
            DictTypes.Add("guid", new TypeGuid());
            DictTypes.Add("datetime", new TypeDatetime());
            DictTypes.Add("boolean", new TypeBool());
            DictTypes.Add("double", new TypeDouble());
            DictTypes.Add("single", new TypeSingle());
            DictTypes.Add("byte", new TypeByte());
            DictTypes.Add("short", new TypeByte());
            DictTypes.Add("default", new TypeDefault());
        }
    }
}
