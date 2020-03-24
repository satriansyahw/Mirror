using EFHelper.Filtering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface IList
    {
        #region Synchronous
        List<T> GetData<T>(List<SearchField> parameters) where T : class;
        List<T> GetData<T>(double longTimeCache, string cacheName, bool isNewData, List<SearchField> parameters) where T : class;
        List<T> GetDataBefore<T>(double longTimeCache, string cacheName, bool isNewData, string dateColumnName, int daysNumber, List<SearchField> parameters) where T : class;
        #endregion

        #region Asynchronous          
        Task<List<T>> GetDataAsync<T>(List<SearchField> parameters) where T : class;
        Task<List<T>> GetDataAsync<T>(double longTimeCache, string cacheName, bool isNewData, List<SearchField> parameters) where T : class;
        Task<List<T>> GetDataBeforeAsync<T>(double longTimeCache, string cacheName, bool isNewData, string dateColumnName, int daysNumber, List<SearchField> parameters) where T : class;
        #endregion
    }
}