using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.ColumnHelper
{
    public class ColumnListInfo
    {
        public string ColName  {get;set;}
        public PropertyInfo ColPropInfo { get; set; }
    }
}
