using System.Threading.Tasks;
using static EFHelper.MiscClass.MiscClass;

namespace MirrorLayer.General.Interface
{
    public interface ISaveUpdateDelete
    {
        bool SaveUpdateDelete<T>(T entity, EnumSaveUpdateDelete enumSUDT, out T @identity) where T : class;
        bool SaveUpdateDelete<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, out T1 @identity1, out T2 @identity2) where T1 : class where T2 : class;
        bool SaveUpdateDelete<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, out T1 @identity1, out T2 @identity2, out T3 @identity3)where T1 : class where T2 : class where T3 : class;        
        bool SaveUpdateDelete<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4)where T1 : class where T2 : class where T3 : class where T4 : class;
        bool SaveUpdateDelete<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4, out T5 @identity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> SaveUpdateDeleteAsync<T>(T entity, EnumSaveUpdateDelete enumSUDT) where T : class;
        Task<bool> SaveUpdateDeleteAsync<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2) where T1 : class where T2 : class;
        Task<bool> SaveUpdateDeleteAsync<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3) where T1 : class where T2 : class where T3 : class;
        Task<bool> SaveUpdateDeleteAsync<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> SaveUpdateDeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}