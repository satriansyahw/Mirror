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
using Microsoft.EntityFrameworkCore;

namespace EFHelper.RepositoryList
{
    public  class RepoListAsync :EFRepoListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private DBCommandRepoListAsync listDBCommand = new DBCommandRepoListAsync();
        private static RepoListAsync instance;
        public static RepoListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoListAsync();
                return instance;
            }
        }
        public override async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) 
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<T>(searchFieldList))
                eFReturn = await base.ListDataAsync<T>(searchFieldList).ConfigureAwait(false);
            else
                eFReturn = await listDBCommand.ListDataAsync<T>(searchFieldList).ConfigureAwait(false);
            return eFReturn;
        }
        public override async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<T>(searchFieldList))
                eFReturn = await base.ListDataAsync<T>(searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
            else
                eFReturn = await listDBCommand.ListDataAsync<T>(searchFieldList,sortColumn,isAscending,topTake).ConfigureAwait(false);
            return eFReturn;
        }
        public override async Task<EFReturnValue> ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)         
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (!ColumnPropGet.GetInstance.GetCheckIsDBCommandList<TSource>(searchFieldList))
                eFReturn = await base.ListDataAsync<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
            else
                eFReturn = await listDBCommand.ListDataAsync<TSource,TResult>(searchFieldList,sortColumn,isAscending,topTake).ConfigureAwait(false);
            return eFReturn;
        }
        public override async Task<EFReturnValue> ListDataAsync<T>()
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            eFReturn = await base.ListDataAsync<T>().ConfigureAwait(false);
            return eFReturn;
        }

       
    }
}
