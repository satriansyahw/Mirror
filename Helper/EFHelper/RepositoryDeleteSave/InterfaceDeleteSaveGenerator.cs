using EFHelper.Filtering;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDeleteSave
{
    public interface InterfaceRepoDeleteSave
    {
        EFReturnValue DeleteSave<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class where T1 : class;
        EFReturnValue DeleteSave<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2) where TDelete : class where T1 : class where T2 : class;
        EFReturnValue DeleteSave<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3) where TDelete : class where T1 : class where T2 : class where T3 : class ;
        EFReturnValue DeleteSave<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteSave<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteSaveList
    {
        EFReturnValue DeleteSaveList<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)where TDelete : class where T1 : class;
        EFReturnValue DeleteSaveList<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)where TDelete : class where T1 : class where T2 : class;
        EFReturnValue DeleteSaveList<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteSaveList<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteSaveList<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteSaveActiveBool
    {
        EFReturnValue DeleteSaveActiveBool<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class where T1 : class;
        EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2) where TDelete : class where T1 : class where T2 : class;
        EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3) where TDelete : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteSaveActiveBoolList
    {
        EFReturnValue DeleteSaveActiveBoolList<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1) where TDelete : class where T1 : class;
        EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2) where TDelete : class where T1 : class where T2 : class;
        EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteSaveAsync
    {
        Task<EFReturnValue> DeleteSaveAsync<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class where T1 : class;
        Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2) where TDelete : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3) where TDelete : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteSaveListAsync
    {
        Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1) where TDelete : class where T1 : class;
        Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2) where TDelete : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteSaveActiveBoolAsync
    {
        Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class where T1 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2) where TDelete : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3) where TDelete : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteSaveActiveBoolListAsync
    {
        Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1) where TDelete : class where T1 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2) where TDelete : class where T1 : class where T2 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
}
