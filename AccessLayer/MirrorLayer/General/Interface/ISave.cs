using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface ISave
    {
        bool Save<T>(T entity, out T @identity) where T : class;
        bool Save<T1, T2>(T1 entity1,  T2 entity2,  out T1 @identity1, out T2 @identity2) where T1 : class where T2 : class;
        bool Save<T1, T2, T3>(T1 entity1,  T2 entity2,  T3 entity3,  out T1 @identity1, out T2 @identity2, out T3 @identity3)where T1 : class where T2 : class where T3 : class;        
        bool Save<T1, T2, T3, T4>(T1 entity1,  T2 entity2,  T3 entity3,  T4 entity4,  out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4)where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Save<T1, T2, T3, T4, T5>(T1 entity1,  T2 entity2,  T3 entity3,  T4 entity4,  T5 entity5, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4, out T5 @identity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> SaveAsync<T>(T entity) where T : class;
        Task<bool> SaveAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<bool> SaveAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> SaveAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> SaveAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}