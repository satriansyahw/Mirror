using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EFHelper.RepositoryList
{
    public class RepoListMiscHelper
    {

        public List<ConvertNoToNamePI> ListColumnConvertPI = new List<ConvertNoToNamePI>();
        public List<ConvertNoToName> ListConvertSelected = new List<ConvertNoToName>();

        public List<T> ConvertDataToListEmpInfo<T, TNoToName>(List<T> listDataWantToConverted, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
         where T : class
         where TNoToName : class, IConvertNoToName
        {
            this.ListColumnConvertPI = ColumnPropGet.GetInstance.GetColumnConvertPI<T>(listColumnConvert);
            for (int i = 0; i < listDataWantToConverted.Count; i++)
            {
                foreach (ConvertNoToNamePI itemPI in ListColumnConvertPI)
                {
                    string strNo = itemPI.SourceNoPropertyInfo.GetValue(listDataWantToConverted[i]).ToString();
                    string strName = string.Empty;
                    if (strNo.Contains(",") || strNo.Contains("|") || strNo.Contains("^") || strNo.Contains("~"))
                        strName = this.ConvertNoToNameProcessArray<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);
                    else
                        strName = this.ConvertNoToNameProcessSingle<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);
                    ColumnPropSet.GetInstance.SetColValue<T>(listDataWantToConverted[i], itemPI.TargetNamePropertyInfo.Name, strName);

                }
            }
            return listDataWantToConverted;
        }

        public string ConvertNoToNameProcessSingle<T, TNoToName>(List<TNoToName> listTableConvert, PropertyInfo targetColNamePI, string strNo)
            where T : class where TNoToName : class, IConvertNoToName
        {
            var CheckIsAlreadySelected = ListConvertSelected.Where(a => a.ColumnNoValue.Trim().ToLower() == strNo.ToLower().Trim()).ToList();
            string strName = string.Empty;
            if (CheckIsAlreadySelected.Count > 0) // select from previous selected
            {
                strName = CheckIsAlreadySelected[0].ToString();
            }
            else
            {
                var checkFromTableConvert = listTableConvert.Where(a => a.EmpNo.Trim().ToLower() == strNo.ToLower().Trim()).ToList();
                if (checkFromTableConvert.Count > 0)
                {
                    strName = checkFromTableConvert[0].ToString();
                    ListConvertSelected.Add(new ConvertNoToName { ColumnNoValue = strNo, ColumnNameValue = strName.ToString() });
                }
                else
                {
                    strName = strNo;
                }
            }
            return strName;

        }
        public string ConvertNoToNameProcessArray<T, TNoToName>(List<TNoToName> listTableConvert, PropertyInfo targetColNamePI, string strNo)
            where T : class where TNoToName : class, IConvertNoToName
        {
            string strName = string.Empty;
            string[] strNoArray = null;
            string pemisah = string.Empty;
            if (strNo.Contains(","))
            {
                pemisah = ",";
                strNoArray = strNo.Replace("|", "").Replace("^", "").Trim().Split(",");
            }
            else if (strNo.Contains("|"))
            {
                pemisah = "|";
                strNoArray = strNo.Replace("^", "").Replace(",", "").Trim().Split("|");
            }
            else if (strNo.Contains("^"))
            {
                pemisah = "^";
                strNoArray = strNo.Replace("|", "").Replace("~", "").Trim().Split("^");
            }
            else if (strNo.Contains("~"))
            {
                pemisah = "~";
                strNoArray = strNo.Replace("|", "").Replace("^", "").Trim().Split("~");
            }
            if (strNoArray != null)
            {
                foreach (string itemNo in strNoArray)
                {
                    string strNameSingle = this.ConvertNoToNameProcessSingle<T, TNoToName>(listTableConvert, targetColNamePI, strNo);
                    strName = string.IsNullOrEmpty(strName) ? strNameSingle : strName + pemisah + strNameSingle;
                }
            }
            return strName;
        }
    }
}
