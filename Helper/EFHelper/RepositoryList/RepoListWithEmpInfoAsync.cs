using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.DBCommandList;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;

namespace EFHelper.RepositoryList
{
    public class RepoListWithEmpInfoAsync : InterfaceRepoListWithEmpInfoAsync
    {       
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private EFRepoListWithEmpInfo repoEmpInfo = new EFRepoListWithEmpInfo();
        private DBCommandRepoListwithEmpInfoAsync repoEmpInfoDBCommand = new DBCommandRepoListwithEmpInfoAsync();
        private static RepoListWithEmpInfoAsync instance;
        public static RepoListWithEmpInfoAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoListWithEmpInfoAsync();
                return instance;
            }
        }

        public virtual async Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where T : class where TNoToName:class,IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            var rv = await RepoListAsync.GetInstance.ListDataAsync<T>();
            if (rv.IsSuccessConnection & rv.IsSuccessQuery)
            {
                var resultList = (List<T>)rv.ReturnValue;
                eFReturn = repoEmpInfo.RepoListEmp<T,TNoToName>(resultList, listTableConvert, listColumnConvert);
            }

            return eFReturn;
        }

        public virtual async Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
            where T : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<T>(searchFieldList))
            {
                eFReturn = await RepoListAsync.GetInstance.ListDataAsync<T>(searchFieldList);

                if (eFReturn.IsSuccessConnection & eFReturn.IsSuccessQuery)
                {
                    var resultList = (List<T>)eFReturn.ReturnValue;
                    eFReturn = repoEmpInfo.RepoListEmp<T, TNoToName>(resultList, listTableConvert, listColumnConvert);
                }
            }
            else
            {
                eFReturn = await repoEmpInfoDBCommand.ListDataWithEmpInfoAsync<T, TNoToName>(listTableConvert, listColumnConvert,searchFieldList).ConfigureAwait(false);
            }
            return eFReturn;
        }

        public virtual async Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where T : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<T>(searchFieldList))
            {
                eFReturn = await RepoListAsync.GetInstance.ListDataAsync<T>(searchFieldList,sortColumn,isAscending,topTake);

                if (eFReturn.IsSuccessConnection & eFReturn.IsSuccessQuery)
                {
                    var resultList = (List<T>)eFReturn.ReturnValue;
                    eFReturn = repoEmpInfo.RepoListEmp<T, TNoToName>(resultList, listTableConvert, listColumnConvert);
                }
            }
            else
            {
                eFReturn = await repoEmpInfoDBCommand.ListDataWithEmpInfoAsync<T, TNoToName>(listTableConvert, listColumnConvert, searchFieldList,sortColumn,isAscending,topTake).ConfigureAwait(false);
            }
            return eFReturn;
        }

        public virtual async Task<EFReturnValue> ListDataWithEmpInfoAsync<TSource, TResult, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class where TResult : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<TSource>(searchFieldList))
            {
                eFReturn = await RepoListAsync.GetInstance.ListDataAsync<TSource,TResult>(searchFieldList, sortColumn, isAscending, topTake);

                if (eFReturn.IsSuccessConnection & eFReturn.IsSuccessQuery)
                {
                    var resultList = (List<TResult>)eFReturn.ReturnValue;
                    eFReturn = repoEmpInfo.RepoListEmp<TResult, TNoToName>(resultList, listTableConvert, listColumnConvert);
                }
            }
            else
            {
                eFReturn = await repoEmpInfoDBCommand.ListDataWithEmpInfoAsync<TResult, TNoToName>(listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
            }
            return eFReturn;
        }
    }
}
