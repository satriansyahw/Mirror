using EFHelper.Filtering;
using MirrorDB;
using MirrorLayer.General.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MirrorLayer.Fake.Interface
{
    public interface IFakeTable: IGenList
    {

        #region Asynchronous
        #region LIST
        Task<List<FakeTable>> List30SecondsAsync(bool isNewData, List<SearchField> lsf);
        #endregion

        #region CRUD
        Task<bool> SaveAsync(FakeTable obj);
        Task<bool> UpdateAllAsync(FakeTable obj);
        Task<bool> UpdateAsync(FakeTable obj);
        Task<bool> DeleteActiveBoolAsync(FakeTable obj);
        Task<bool> DeleteFisikAsync(FakeTable obj);
        #endregion
        #endregion 
    }
}
