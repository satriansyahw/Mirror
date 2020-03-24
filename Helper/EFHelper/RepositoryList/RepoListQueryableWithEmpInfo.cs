using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFHelper.Filtering;
using EFHelper.MiscClass;

namespace EFHelper.RepositoryList
{
    public class RepoListQueryableWithEmpInfo : InterfaceRepoListQueryableWithEmpInfo
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoListQueryableWithEmpInfo instance;
        private EFRepoListWithEmpInfo repoEmpInfo = new EFRepoListWithEmpInfo();
        public static RepoListQueryableWithEmpInfo GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoListQueryableWithEmpInfo();
                return instance;
            }
        }
        public virtual EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert) where TResult : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            var rv = RepoListQueryable.GetInstance.ListDataQueryable<TResult>(queryable, null, string.Empty, false, 0);
            if (rv.IsSuccessConnection & rv.IsSuccessQuery)
            {
                var resultList = (List<TResult>)rv.ReturnValue;
                eFReturn = repoEmpInfo.RepoListEmp<TResult, TNoToName>(resultList, listTableConvert, listColumnConvert);

            }
            return eFReturn;
        }

        public virtual EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList) where TResult : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            var rv = RepoListQueryable.GetInstance.ListDataQueryable<TResult>(queryable, searchFieldList, string.Empty, false, 0);
            if (rv.IsSuccessConnection & rv.IsSuccessQuery)
            {
                var resultList = (List<TResult>)rv.ReturnValue;
                eFReturn = repoEmpInfo.RepoListEmp<TResult, TNoToName>(resultList, listTableConvert, listColumnConvert);

            }
            return eFReturn;

        }

        public virtual EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class where TNoToName : class, IConvertNoToName
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            var rv = RepoListQueryable.GetInstance.ListDataQueryable<TResult>(queryable, searchFieldList, sortColumn, isAscending, topTake);
            if (rv.IsSuccessConnection & rv.IsSuccessQuery)
            {
                var resultList = (List<TResult>)rv.ReturnValue;
                eFReturn = repoEmpInfo.RepoListEmp<TResult, TNoToName>(resultList, listTableConvert, listColumnConvert);

            }
            return eFReturn;
        }

    }
}
