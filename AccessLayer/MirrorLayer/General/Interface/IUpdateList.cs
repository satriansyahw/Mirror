using System.Collections.Generic;
using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface IUpdateList
    {
        bool UpdateList<T>(List<T> entity1) where T : class;
        bool UpdateList<T1, T2>(List<T1> entity1, List<T2> entity2) where T1 : class where T2 : class;
        bool UpdateList<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3) where T1 : class where T2 : class where T3 : class;
        bool UpdateList<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool UpdateList<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> UpdateListAsync<T>(List<T> entity1) where T : class;
        Task<bool> UpdateListAsync<T1, T2>(List<T1> entity1, List<T2> entity2) where T1 : class where T2 : class;
        Task<bool> UpdateListAsync<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> UpdateListAsync<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> UpdateListAsync<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}