using EFHelper;
using EFHelper.ColumnHelper;
using EFHelper.Filtering;
using MirrorDB;
using System; 
using System.Collections.Generic;
using MirrorLayer.General.Interface;
using System.Threading.Tasks;
using EFHelper.RepositoryList;
using MirrorLayer.General.Helper.MemCache;

namespace MirrorLayer.General.DAL
{
    public class DALList : IList
    {
        private static DALList instance;
        public static DALList GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALList();
                return instance;
            }
        }

        #region Synchronous
        public List<T> GetData<T>(List<SearchField> parameters) where T : class
        {
            InterfaceRepoList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.ListData<T>(parameters);
            List<T> listResult = new List<T>();
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
                listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
            
            return listResult;
        }         
        public List<T> GetData<T>(double longTimeCache, string cacheName, bool isNewData, List<SearchField> parameters) where T : class
        {
            InterfaceRepoList repoWrapper = new RepoWrapper(new MirrorDBContext());
            List<T> listResult = new List<T>();
            var resultRepo = repoWrapper.ListData<T>(parameters);
            if (isNewData)
            {
                if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
                {
                    listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                    MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                }
            }
            else
            {
                object objResult = MemoryCacher.GetInstance.GetValue(cacheName);
                if (objResult != null)
                {
                    listResult = (List<T>)objResult;
                }
                else
                {
                    if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
                    {
                        listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                        MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                    }
                }
            }
            return listResult;
        }
        public List<T> GetDataBefore<T>(double longTimeCache, string cacheName, bool isNewData, string dateColumnName, int daysNumber, List<SearchField> parameters) where T : class
        {
            InterfaceRepoList repoWrapper = new RepoWrapper(new MirrorDBContext());
            List<T> listResult = new List<T>();
            var propColName = ColumnPropGet.GetInstance.GetColumnProps<T>(dateColumnName);
            if (propColName != null)
            {
                string dateTime = DateTime.Now.AddDays(daysNumber).ToString("yyyy-MM-dd");
                parameters.Add(new SearchField { Name = dateColumnName, Operator = "<", Value = dateTime });
            }
            var resultRepo = repoWrapper.ListData<T>(parameters);
            if (isNewData)
            {
                if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
                {
                    listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                    MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                }
            }
            else
            {
                object objResult = MemoryCacher.GetInstance.GetValue(cacheName);
                if (objResult != null)
                {
                    listResult = (List<T>)objResult;
                }
                else
                {
                    if (resultRepo.IsSuccessQuery & resultRepo.IsSuccessConnection)
                    {
                        listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                        MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                    }
                }
            }
            return listResult;
        }
        #endregion

        #region Asynchronous          
        public async Task<List<T>> GetDataAsync<T>(List<SearchField> parameters) where T : class
        {
            RepoWrapperAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.ListDataAsync<T>(parameters);
            List<T> listResult = new List<T>();
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
            }
            return listResult;
        }
        public async Task<List<T>> GetDataAsync<T>(double longTimeCache, string cacheName, bool isNewData, List<SearchField> parameters) where T : class
        {
            RepoWrapperAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            List<T> listResult = new List<T>();
            var resultRepo = await repoWrapperAsync.ListDataAsync<T>(parameters);
            if (isNewData)
            {
                if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
                {
                    listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                    MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                }
            }
            else
            {
                object objResult = MemoryCacher.GetInstance.GetValue(cacheName);
                if (objResult != null)
                {
                    listResult = (List<T>)objResult;
                }
                else
                {
                    if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
                    {
                        listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                        MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                    }
                }
            }
            return listResult;
        }
        public async Task<List<T>> GetDataBeforeAsync<T>(double longTimeCache, string cacheName, bool isNewData, string dateColumnName, int daysNumber, List<SearchField> parameters) where T : class
        {
            RepoWrapperAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            List<T> listResult = new List<T>();
            var propColName = ColumnPropGet.GetInstance.GetColumnProps<T>(dateColumnName);
            if (propColName != null)
            {
                string dateTime = DateTime.Now.AddDays(daysNumber).ToString("yyyy-MM-dd");
                parameters.Add(new SearchField { Name = dateColumnName, Operator = "<", Value = dateTime });
            }
            var resultRepo = await repoWrapperAsync.ListDataAsync<T>(parameters);
            if (isNewData)
            {
                if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
                {
                    listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                    MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                }
            }
            else
            {
                object objResult = MemoryCacher.GetInstance.GetValue(cacheName);
                if (objResult != null)
                {
                    listResult = (List<T>)objResult;
                }
                else
                {
                    if (resultRepo.IsSuccessQuery & resultRepo.IsSuccessConnection)
                    {
                        listResult = (List<T>)resultRepo.ReturnValue[0].ReturnValue;
                        MemoryCacher.GetInstance.AddSeconds(cacheName, listResult, longTimeCache);
                    }
                }
            }
            return listResult;
        }
        #endregion
    }
}