using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace EFHelper.RepositoryList
{

    public class EFRepoListWithEmpInfo
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        RepoListMiscHelper listHelper = new RepoListMiscHelper();

        public EFRepoListWithEmpInfo()
        {

        }
        public EFReturnValue RepoListEmp<T, TNoToName>(List<T> listDataSource, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where T : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            try
            {
                if (listDataSource != null & listTableConvert != null)
                {
                    if (listDataSource.Count > 0 & listTableConvert.Count > 0 & listHelper.ListConvertSelected.Count > 0)
                    {
                        listHelper.ListColumnConvertPI = ColumnPropGet.GetInstance.GetColumnConvertPI<T>(listColumnConvert);
                        listDataSource = this.ConvertNoToNameProcess<T, TNoToName>(listDataSource, listTableConvert);
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listDataSource);
                    }

                }
            }
            catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
            return eFReturn;
        }



        private List<T> ConvertNoToNameProcess<T, TNoToName>(List<T> listData, List<TNoToName> listTableConvert)
            where T : class where TNoToName : class, IConvertNoToName
        {
            for (int i = 0; i < listData.Count; i++)
            {
                T classToUpdate = (T)listData[i];
                foreach (ConvertNoToNamePI itemPI in listHelper.ListColumnConvertPI)
                {
                    object objNo = itemPI.SourceNoPropertyInfo.GetValue(classToUpdate);
                    string strNo = string.Empty;
                    string strName = string.Empty;
                    if (objNo != null)
                    {
                        strNo = objNo.ToString().ToLower().Trim();
                        if (strNo.Contains(",") || strNo.Contains("|") || strNo.Contains("^") || strNo.Contains("~"))
                            strName = listHelper.ConvertNoToNameProcessArray<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);
                        else
                            strName = listHelper.ConvertNoToNameProcessSingle<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);
                        ColumnPropSet.GetInstance.SetColValue<T>(classToUpdate, itemPI.TargetNamePropertyInfo.Name, strName);
                        listData[i] = classToUpdate;

                    }

                }
            }
            return listData;
        }

      
    }

}
