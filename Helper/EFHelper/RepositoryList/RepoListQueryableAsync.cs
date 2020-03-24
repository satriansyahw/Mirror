using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;

namespace EFHelper.RepositoryList
{
    public class RepoListQueryableAsync : InterfaceRepoListQueryableAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoListQueryableAsync instance;
        public static RepoListQueryableAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoListQueryableAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable) where TResult : class
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            try
            {
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<TResult>(queryable, null, string.Empty, false, 0);
                //var result =await queryable.ToListAsync();           
                List<TResult> result = new List<TResult>();
                result = await queryable.ToListAsync().ConfigureAwait(false);

                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
            }
            catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList) where TResult : class
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            try
            {
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<TResult>(queryable, searchFieldList, string.Empty, false, 0);
                //var result = await queryable.ToListAsync();        
                List<TResult> result = new List<TResult>();
                result = await queryable.ToListAsync().ConfigureAwait(false);
                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
            }
            catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            try
            {
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<TResult>(queryable, searchFieldList, sortColumn,isAscending,topTake);
                //var result = await queryable.ToListAsync();
                List<TResult> result = new List<TResult>();             
                result =await queryable.ToListAsync().ConfigureAwait(false);               
                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
            }
            catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }

            return eFReturn;
        }
    }
}
