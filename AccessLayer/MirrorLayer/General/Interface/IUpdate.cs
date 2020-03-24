using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface IUpdate
    {
        bool Update<T>(T entity1) where T : class;
        bool Update<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        bool Update<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        bool Update<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Update<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> UpdateAsync<T>(T entity1) where T : class;
        Task<bool> UpdateAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<bool> UpdateAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> UpdateAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> UpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}