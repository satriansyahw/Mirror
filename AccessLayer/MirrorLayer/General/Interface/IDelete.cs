using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface IDelete
    {
        bool Delete<T>(int IDIdentity) where T : class;
        bool Delete<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        bool Delete<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        bool Delete<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Delete<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        bool Delete<T>(T entity) where T : class;
        bool Delete<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        bool Delete<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        bool Delete<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Delete<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> DeleteAsync<T>(int IDIdentity) where T : class;
        Task<bool> DeleteAsync<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        Task<bool> DeleteAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> DeleteAsync<T>(T entity) where T : class;
        Task<bool> DeleteAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<bool> DeleteAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}