using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositorySaveUpdate
{
    public interface InterfaceRepoSaveUpdate
    {
        EFReturnValue SaveUpdate<T1>(T1 entity1, bool isSaveT1) where T1 : class;
        EFReturnValue SaveUpdate<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2) where T1 : class where T2 : class;
        EFReturnValue SaveUpdate<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue SaveUpdate<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue SaveUpdate<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoSaveUpdateList
    {
        EFReturnValue SaveUpdateList<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class;
        EFReturnValue SaveUpdateList<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2) where T1 : class where T2 : class;
        EFReturnValue SaveUpdateList<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue SaveUpdateList<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue SaveUpdateList<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoSaveUpdateAsync
    {
        Task<EFReturnValue> SaveUpdateAsync<T1>(T1 entity1, bool isSaveT1) where T1 : class;
        Task<EFReturnValue> SaveUpdateAsync<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2) where T1 : class where T2 : class;
        Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoSaveUpdateListAsync
    {
        Task<EFReturnValue> SaveUpdateListAsync<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class;
        Task<EFReturnValue> SaveUpdateListAsync<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2) where T1 : class where T2 : class;
        Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
}
