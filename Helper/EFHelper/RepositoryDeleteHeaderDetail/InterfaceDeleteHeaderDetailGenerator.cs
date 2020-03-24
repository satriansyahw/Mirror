using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public interface InterfaceRepoDeleteHeaderDetail
    {
        EFReturnValue DeleteHeaderDetail<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        EFReturnValue DeleteHeaderDetail<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        EFReturnValue DeleteHeaderDetail<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteHeaderDetailAsync
    {
        Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteHeaderDetailList
    {
        EFReturnValue DeleteHeaderDetailList<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        EFReturnValue DeleteHeaderDetailList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteHeaderDetailListAsync
    {
        Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteHeaderDetailActiveBool
    {
        EFReturnValue DeleteHeaderDetailActiveBool<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteHeaderDetailActiveBoolAsync
    {
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteHeaderDetailActiveBoolList
    {
        EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteHeaderDetailActiveBoolListAsync
    {
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
}
