using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.Filtering
{
    public class SearchField
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public string Operator { get; set; }
    }
    public class APIReturn
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
    }
    public class APIReturn2
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
    }
    public class APIReturn3
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
    }
    public class APIReturn4
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
        public object Data4 { get; set; }
    }
    public class APIReturn5
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
        public object Data4 { get; set; }
        public object Data5 { get; set; }
    }
    public class APIReturn6
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
        public object Data4 { get; set; }
        public object Data5 { get; set; }
        public object Data6 { get; set; }
    }
    public class APIReturn7
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
        public object Data4 { get; set; }
        public object Data5 { get; set; }
        public object Data6 { get; set; }
        public object Data7 { get; set; }
    }
    public class APIReturn8
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
        public object Data4 { get; set; }
        public object Data5 { get; set; }
        public object Data6 { get; set; }
        public object Data7 { get; set; }
        public object Data8 { get; set; }
    }
    public class APIReturn9
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
        public object Data4 { get; set; }
        public object Data5 { get; set; }
        public object Data6 { get; set; }
        public object Data7 { get; set; }
        public object Data8 { get; set; }
        public object Data9 { get; set; }
    }
    public class APIReturn10
    {
        public string Message { get; set; }
        public object Data1 { get; set; }
        public object Data2 { get; set; }
        public object Data3 { get; set; }
        public object Data4 { get; set; }
        public object Data5 { get; set; }
        public object Data6 { get; set; }
        public object Data7 { get; set; }
        public object Data8 { get; set; }
        public object Data9 { get; set; }
        public object Data10 { get; set; }
    }
    public class ParamSearchField
    {
        public string TabName { get; set; }
        public int TopTake { get; set; }
        public string SortColumn { get; set; }
        public bool IsSortAscending { get; set; }
        public string EmpnoLogin { get; set; }
        public List<SearchField> ListSearchField { get; set; }
        public bool AllDataBool { get; set; }

    }
    public class SearchParameter
    {
        public List<SearchField> SearchFieldList { get; set; }
        public string SortColumn { get; set; }
        public bool IsAscending { get; set; }
        public int TopTake { get; set; }
    }
    public class DeleteByID
    {
        public int UserId { get; set; }
        public string UserByName { get; set; }
        public int IdentityId { get; set; }
    }
    public class DeleteByIDList
    {
        public int UserId { get; set; }
        public string UserByName { get; set; }
        public List<int> IdentityId { get; set; }
    }

}
