using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static EFHelper.MiscClass.MiscClass;

namespace EFHelper.RepositorySaveUpdateDelete
{
    public interface InterfaceRepoSaveUpdateDelete
    {
        EFReturnValue SaveUpdateDelete<T1>(T1 entity1, EnumSaveUpdateDelete enumSUDT1) where T1 : class;
        EFReturnValue SaveUpdateDelete<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2)
            where T1 : class where T2 : class;
        EFReturnValue SaveUpdateDelete<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3)
            where T1 : class where T2 : class where T3 : class;
        EFReturnValue SaveUpdateDelete<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class ;
        EFReturnValue SaveUpdateDelete<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveUpdateDeleteList
    {
        EFReturnValue SaveUpdateDeleteList<T1>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1)
            where T1 : class;
        EFReturnValue SaveUpdateDeleteList<T1, T2>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2)
                    where T1 : class where T2 : class;
        EFReturnValue SaveUpdateDeleteList<T1, T2, T3>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3)
                    where T1 : class where T2 : class where T3 : class;
        EFReturnValue SaveUpdateDeleteList<T1, T2, T3, T4>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue SaveUpdateDeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveUpdateDeleteActiveBool
    {
        EFReturnValue SaveUpdateDeleteActiveBool<T1>(T1 entity1, EnumSaveUpdateDelete enumSUDT1) where T1 : class;
        EFReturnValue SaveUpdateDeleteActiveBool<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2)
            where T1 : class where T2 : class;
        EFReturnValue SaveUpdateDeleteActiveBool<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3)
            where T1 : class where T2 : class where T3 : class;
        EFReturnValue SaveUpdateDeleteActiveBool<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue SaveUpdateDeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveUpdateDeleteActiveBoolList
    {
        EFReturnValue SaveUpdateDeleteActiveBoolList<T1>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1)
            where T1 : class;
        EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2)
                    where T1 : class where T2 : class;
        EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3)
                    where T1 : class where T2 : class where T3 : class;
        EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveUpdateDeleteAsync
    {
        Task<EFReturnValue> SaveUpdateDeleteAsync<T1>(T1 entity1, EnumSaveUpdateDelete enumSUDT1) where T1 : class;
        Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2)
            where T1 : class where T2 : class;
        Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3)
            where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveUpdateDeleteListAsync
    {
        Task<EFReturnValue> SaveUpdateDeleteListAsync<T1>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1)
            where T1 : class;
        Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2)
                    where T1 : class where T2 : class;
        Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3)
                    where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveUpdateDeleteActiveBoolAsync
    {
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1>(T1 entity1, EnumSaveUpdateDelete enumSUDT1) where T1 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2)
            where T1 : class where T2 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3)
            where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveUpdateDeleteActiveBoolListAsync
    {
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1)
            where T1 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2)
                    where T1 : class where T2 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3)
                    where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}
