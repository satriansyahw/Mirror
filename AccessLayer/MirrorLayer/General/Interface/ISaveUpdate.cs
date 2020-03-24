using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface ISaveUpdate
    {
        bool SaveUpdate<T>(T entity, bool isSaveT, out T @identity) where T : class;
        bool SaveUpdate<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, out T1 @identity1, out T2 @identity2) where T1 : class where T2 : class;
        bool SaveUpdate<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, out T1 @identity1, out T2 @identity2, out T3 @identity3)where T1 : class where T2 : class where T3 : class;        
        bool SaveUpdate<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4)where T1 : class where T2 : class where T3 : class where T4 : class;
        bool SaveUpdate<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4, out T5 @identity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
     
        bool SaveUpdate<T>(T entity, bool isSaveT) where T : class;
        bool SaveUpdate<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2) where T1 : class where T2 : class;
        bool SaveUpdate<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        bool SaveUpdate<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool SaveUpdate<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
        
        Task<bool> SaveUpdateAsync<T>(T entity, bool isSaveT) where T : class;
        Task<bool> SaveUpdateAsync<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2) where T1 : class where T2 : class;
        Task<bool> SaveUpdateAsync<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        Task<bool> SaveUpdateAsync<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> SaveUpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
}