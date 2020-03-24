using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDelete
{
    public interface InterfaceRepoDelete
    {
     
        EFReturnValue Delete<T>(int IDIdentity) where T : class;
        EFReturnValue Delete<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        EFReturnValue Delete<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue Delete<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue Delete<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
      
        EFReturnValue Delete<T>(T entity) where T : class;
        EFReturnValue Delete<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        EFReturnValue Delete<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue Delete<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue Delete<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoDeleteList
    {
        EFReturnValue DeleteList<T>(List<T> listEntity) where T : class;
        EFReturnValue DeleteList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        EFReturnValue DeleteList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        EFReturnValue DeleteList<T>(List<int> listIDIdentity) where T : class;
        EFReturnValue DeleteList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2) where T1 : class where T2 : class;
        EFReturnValue DeleteList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }

    public interface InterfaceRepoDeleteAsync
    {
        Task<EFReturnValue> DeleteAsync<T>(int IDIdentity) where T : class;
        Task<EFReturnValue> DeleteAsync<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<EFReturnValue> DeleteAsync<T>(T entity) where T : class;
        Task<EFReturnValue> DeleteAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteListAsync
    {

        Task<EFReturnValue> DeleteListAsync<T>(List<T> listEntity) where T : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<EFReturnValue> DeleteListAsync<T>(List<int> listIDIdentity) where T : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;


    }
    public interface InterfaceRepoDeleteActiveBool
    {
        EFReturnValue DeleteActiveBool<T>(int IDIdentity) where T : class;
        EFReturnValue DeleteActiveBool<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        EFReturnValue DeleteActiveBool<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        EFReturnValue DeleteActiveBool<T>(T entity) where T : class;
        EFReturnValue DeleteActiveBool<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        EFReturnValue DeleteActiveBool<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
      
    }
    public interface InterfaceRepoDeleteActiveBoolList
    {

        EFReturnValue DeleteActiveBoolList<T>(List<T> listEntity) where T : class;
        EFReturnValue DeleteActiveBoolList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        EFReturnValue DeleteActiveBoolList<T>(List<int> listIDIdentity) where T : class;
        EFReturnValue DeleteActiveBoolList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2) where T1 : class where T2 : class;
        EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3) where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;


    }
    public interface InterfaceRepoDeleteActiveBoolAsync
    {
        Task<EFReturnValue> DeleteActiveBoolAsync<T>(T entity) where T : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<EFReturnValue> DeleteActiveBoolAsync<T>(int IDIdentity) where T : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;


    }
    public interface InterfaceRepoDeleteActiveBoolListAsync
    {
        Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<T> listEntity) where T : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;


        Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<int> listIDIdentity) where T : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2) where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3) where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;


    }

}
