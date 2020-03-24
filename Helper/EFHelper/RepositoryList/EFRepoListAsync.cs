using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;

namespace EFHelper.RepositoryList
{
    public  class EFRepoListAsync : InterfaceRepoListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        public virtual async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, searchFieldList, string.Empty, false, 0);
                    // ef original Async List still found bugs, so change to Task.Run Async 
                    List<T> result = new List<T>();
                    result = await queryable.ToListAsync().ConfigureAwait(false);
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, searchFieldList, sortColumn, isAscending, topTake);
                    List<T> result = new List<T>();
                    result = await queryable.ToListAsync().ConfigureAwait(false);
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
            }
            return eFReturn;

        }
        public virtual async Task<EFReturnValue> ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<TSource>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    // var result = await query.QueryGeneratorList<TSource, TResult>(queryable, searchFieldList, sortColumn, false, topTake).ToListAsync();
                    List<TResult> result = new List<TResult>();            
                        result = await query.QueryGeneratorList<TSource, TResult>(queryable, searchFieldList, sortColumn, false, topTake).ToListAsync().ConfigureAwait(false);
               


                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
            }
            return eFReturn;

        }

        public virtual async Task<EFReturnValue> ListDataAsync<T>() where T : class
        {
            eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, null, string.Empty, false, 0);               
                    List<T> result = new List<T>();                  
                        result = await queryable.ToListAsync().ConfigureAwait(false);                 

                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
            }
            return eFReturn;
        }

       
    }
}
