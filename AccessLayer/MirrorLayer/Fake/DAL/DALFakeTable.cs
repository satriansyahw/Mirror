using EFHelper.Filtering;
using MirrorDB;
using MirrorLayer.Fake.Interface;
using MirrorLayer.General.DAL;
using MirrorLayer.General.Helper.MemCache;
using MirrorLayer.General.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MirrorLayer.Fake.DAL
{
    public class DALFakeTable:IFakeTable
    {
        private readonly double cacheLimit = MemCacheFake.GetInstance.CacheLimitFakeTable;
        private readonly string cacheName = MemCacheFake.GetInstance.CacheNameFakeTable;

        private readonly IList listData = DALList.GetInstance;
        private readonly ISave saveData = DALSave.GetInstance;
        private readonly IUpdateAll updateAllData = DALUpdateAll.GetInstance;
        private readonly IUpdate updateData = DALUpdate.GetInstance;
        private readonly IDeleteActiveBool deleteActiveBoolData = DALDeleteActiveBool.GetInstance;
        private readonly IDelete deleteFisikData = DALDelete.GetInstance;

        private static DALFakeTable instance;
        public static DALFakeTable GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALFakeTable();
                return instance;
            }
        }
        public async Task<bool> DeleteActiveBoolAsync(FakeTable obj)
        {
            return await deleteActiveBoolData.DeleteActiveBoolAsync<FakeTable>(obj); 
        }

        public async Task<bool> DeleteFisikAsync(FakeTable obj)
        {
            return await deleteFisikData.DeleteAsync<FakeTable>(obj);
        }

        public object ListData(List<SearchField> lsf)
        {
            return listData.GetData<FakeTable>(lsf);
        }

        public async Task<object> ListDataAsync(List<SearchField> lsf)
        {
            return await listData.GetDataAsync<FakeTable>(lsf);
        }

        public async Task<List<FakeTable>> List30SecondsAsync(bool isNewData, List<SearchField> lsf)
        {
            return  await listData.GetDataAsync<FakeTable>(MemCacheFake.GetInstance.CacheLimitFakeTable, MemCacheFake.GetInstance.CacheNameFakeTable, isNewData, lsf);

        }

        public async Task<bool> SaveAsync(FakeTable obj)
        {
            return await saveData.SaveAsync<FakeTable>(obj);
        }

        public async Task<bool> UpdateAllAsync(FakeTable obj)
        {
            return await updateAllData.UpdateAllAsync<FakeTable>(obj);
        }



        public async Task<bool> UpdateAsync(FakeTable obj)
        {
            return await updateData.UpdateAsync<FakeTable>(obj);
        }
    }
}
