using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryUpdate
{
    public interface InterfaceRepoUpdate
    {
        EFReturnValue Update<T>(T entity) where T : class;
        EFReturnValue Update<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        EFReturnValue Update<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue Update<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue Update<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoUpdateList
    {
        EFReturnValue UpdateList<T>(List<T> listlistEntity) where T : class;
        EFReturnValue UpdateList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        EFReturnValue UpdateList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue UpdateList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue UpdateList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }

    public interface InterfaceRepoUpdateAll
    {
        EFReturnValue UpdateAll<T>(T entity) where T : class;
        EFReturnValue UpdateAll<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        EFReturnValue UpdateAll<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue UpdateAll<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue UpdateAll<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoUpdateAllList
    {
        EFReturnValue UpdateAllList<T>(List<T> listEntity) where T : class;
        EFReturnValue UpdateAllList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        EFReturnValue UpdateAllList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue UpdateAllList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue UpdateAllList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoUpdateAsync
    {
        Task<EFReturnValue> UpdateAsync<T>(T entity) where T : class;
        Task<EFReturnValue> UpdateAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<EFReturnValue> UpdateAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoUpdateListAsync
    {
        Task<EFReturnValue> UpdateListAsync<T>(List<T> listlistEntity) where T : class;
        Task<EFReturnValue> UpdateListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        Task<EFReturnValue> UpdateListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }

    public interface InterfaceRepoUpdateAllAsync
    {
        Task<EFReturnValue> UpdateAllAsync<T>(T entity) where T : class;
        Task<EFReturnValue> UpdateAllAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<EFReturnValue> UpdateAllAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoUpdateAllListAsync
    {
        Task<EFReturnValue> UpdateAllListAsync<T>(List<T> listEntity) where T : class;
        Task<EFReturnValue> UpdateAllListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
}
