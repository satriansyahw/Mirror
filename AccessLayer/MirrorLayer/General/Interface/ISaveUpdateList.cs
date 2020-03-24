using System.Collections.Generic;
using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface ISaveUpdateList
    {
        bool SaveUpdateList<T>(List<T> entity, bool isSaveT, out T @identity) where T : class;
        bool SaveUpdateList<T1, T2>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, out T1 @identity1, out T2 @identity2) where T1 : class where T2 : class;
        bool SaveUpdateList<T1, T2, T3>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, out T1 @identity1, out T2 @identity2, out T3 @identity3)where T1 : class where T2 : class where T3 : class;        
        bool SaveUpdateList<T1, T2, T3, T4>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4)where T1 : class where T2 : class where T3 : class where T4 : class;
        bool SaveUpdateList<T1, T2, T3, T4, T5>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, List<T5> entity5, bool isSaveT5, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4, out T5 @identity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        bool SaveUpdateList<T>(List<T> entity, bool isSaveT) where T : class;
        bool SaveUpdateList<T1, T2>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2) where T1 : class where T2 : class;
        bool SaveUpdateList<T1, T2, T3>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        bool SaveUpdateList<T1, T2, T3, T4>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool SaveUpdateList<T1, T2, T3, T4, T5>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, List<T5> entity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> SaveUpdateListAsync<T>(List<T> entity, bool isSaveT) where T : class;
        Task<bool> SaveUpdateListAsync<T1, T2>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2) where T1 : class where T2 : class;
        Task<bool> SaveUpdateListAsync<T1, T2, T3>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3) where T1 : class where T2 : class where T3 : class;
        Task<bool> SaveUpdateListAsync<T1, T2, T3, T4>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> SaveUpdateListAsync<T1, T2, T3, T4, T5>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, List<T5> entity5, bool isSaveT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}