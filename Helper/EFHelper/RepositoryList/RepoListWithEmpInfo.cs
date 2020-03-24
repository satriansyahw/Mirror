using System;
using System.Collections.Generic;
using System.Linq;
using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.DBCommandList;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;

namespace EFHelper.RepositoryList
{
    public class RepoListWithEmpInfo : InterfaceRepoListWithEmpInfo
    {       
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private EFRepoListWithEmpInfo repoEmpInfo = new EFRepoListWithEmpInfo();
        private DBCommandRepoListWithEmpInfo repoEmpInfoDBCommand = new DBCommandRepoListWithEmpInfo();
        private static RepoListWithEmpInfo instance;
        public static RepoListWithEmpInfo GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoListWithEmpInfo();
                return instance;
            }
        }

        public virtual EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where T : class where TNoToName:class,IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            var rv = RepoList.GetInstance.ListData<T>();
            if (rv.IsSuccessConnection & rv.IsSuccessQuery)
            {
                var resultList = (List<T>)rv.ReturnValue;
                eFReturn = repoEmpInfo.RepoListEmp<T,TNoToName>(resultList, listTableConvert, listColumnConvert);

            }

            return eFReturn;
        }

        public virtual EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
            where T : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<T>(searchFieldList))
            {
                eFReturn = RepoList.GetInstance.ListData<T>(searchFieldList);

                if (eFReturn.IsSuccessConnection & eFReturn.IsSuccessQuery)
                {
                    var resultList = (List<T>)eFReturn.ReturnValue;
                    eFReturn = repoEmpInfo.RepoListEmp<T, TNoToName>(resultList, listTableConvert, listColumnConvert);
                }
            }
            else
            {
                eFReturn = repoEmpInfoDBCommand.ListDataWithEmpInfo<T, TNoToName>(listTableConvert, listColumnConvert,searchFieldList);
            }
            return eFReturn;
        }

        public virtual EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where T : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<T>(searchFieldList))
            {
                eFReturn = RepoList.GetInstance.ListData<T>(searchFieldList,sortColumn,isAscending,topTake);

                if (eFReturn.IsSuccessConnection & eFReturn.IsSuccessQuery)
                {
                    var resultList = (List<T>)eFReturn.ReturnValue;
                    eFReturn = repoEmpInfo.RepoListEmp<T, TNoToName>(resultList, listTableConvert, listColumnConvert);
                }
            }
            else
            {
                eFReturn = repoEmpInfoDBCommand.ListDataWithEmpInfo<T, TNoToName>(listTableConvert, listColumnConvert, searchFieldList,sortColumn,isAscending,topTake);
            }
            return eFReturn;
        }

        public virtual EFReturnValue ListDataWithEmpInfo<TSource, TResult, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class where TResult : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<TSource>(searchFieldList))
            {
                eFReturn = RepoList.GetInstance.ListData<TSource,TResult>(searchFieldList, sortColumn, isAscending, topTake);

                if (eFReturn.IsSuccessConnection & eFReturn.IsSuccessQuery)
                {
                    var resultList = (List<TResult>)eFReturn.ReturnValue;
                    eFReturn = repoEmpInfo.RepoListEmp<TResult, TNoToName>(resultList, listTableConvert, listColumnConvert);
                }
            }
            else
            {
                eFReturn = repoEmpInfoDBCommand.ListDataWithEmpInfo<TResult, TNoToName>(listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake);
            }
            return eFReturn;
        }
    }
}
