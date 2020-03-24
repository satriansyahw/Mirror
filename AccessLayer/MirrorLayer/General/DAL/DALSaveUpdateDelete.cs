using EFHelper;
using EFHelper.RepositorySaveUpdateDelete;
using MirrorDB; 
using MirrorLayer.General.Interface;
using System.Threading.Tasks;
using static EFHelper.MiscClass.MiscClass;

namespace MirrorLayer.General.DAL
{
    public class DALSaveUpdateDelete : ISaveUpdateDelete
    {
        private static DALSaveUpdateDelete instance;
        public static DALSaveUpdateDelete GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALSaveUpdateDelete();
                return instance;
            }
        }

        #region Synchronous
        public bool SaveUpdateDelete<T>(T entity, EnumSaveUpdateDelete enumSUDT, out T @identity) where T : class
        {
            bool @bool = false;
            @identity = null;
            InterfaceRepoSaveUpdateDelete repoSaveUpdateDelete = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateDelete.SaveUpdateDelete<T>(entity, enumSUDT);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                identity = (T)resultRepo.ReturnValue[0].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateDelete<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, out T1 @resultEntity1, out T2 @resultEntity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            @resultEntity1 = null;
            @resultEntity2 = null;
            InterfaceRepoSaveUpdateDelete repoSaveUpdateDelete = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateDelete.SaveUpdateDelete<T1, T2>(entity1, enumSUDT1, entity2, enumSUDT2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @resultEntity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @resultEntity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateDelete<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, out T1 @identity1, out T2 @identity2, out T3 @identity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            @identity1 = null;
            @identity2 = null;
            @identity3 = null;
            InterfaceRepoSaveUpdateDelete repoSaveUpdateDelete = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateDelete.SaveUpdateDelete<T1, T2, T3>(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @identity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @identity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @identity3 = (T3)resultRepo.ReturnValue[2].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateDelete<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
        {
            bool @bool = false;
            @identity1 = null;
            @identity2 = null;
            @identity3 = null;
            @identity4 = null;
            InterfaceRepoSaveUpdateDelete repoSaveUpdateDelete = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateDelete.SaveUpdateDelete<T1, T2, T3, T4>(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @identity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @identity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @identity3 = (T3)resultRepo.ReturnValue[2].ReturnValue;
                @identity4 = (T4)resultRepo.ReturnValue[3].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateDelete<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4, out T5 @identity5)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
          where T5 : class
        {
            bool @bool = false;
            @identity1 = null;
            @identity2 = null;
            @identity3 = null;
            @identity4 = null;
            @identity5 = null;
            InterfaceRepoSaveUpdateDelete repoSaveUpdateDelete = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateDelete.SaveUpdateDelete<T1, T2, T3, T4, T5>(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @identity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @identity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @identity3 = (T3)resultRepo.ReturnValue[2].ReturnValue;
                @identity4 = (T4)resultRepo.ReturnValue[3].ReturnValue;
                @identity5 = (T5)resultRepo.ReturnValue[4].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        #endregion

        #region Asynchronous
        public async Task<bool> SaveUpdateDeleteAsync<T>(T entity, EnumSaveUpdateDelete enumSUDT) where T : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateDeleteAsync repoSaveUpdateDeleteAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateDeleteAsync.SaveUpdateDeleteAsync<T>(entity, enumSUDT);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateDeleteAsync<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateDeleteAsync repoSaveUpdateDeleteAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateDeleteAsync.SaveUpdateDeleteAsync<T1, T2>(entity1, enumSUDT1, entity2, enumSUDT2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateDeleteAsync<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateDeleteAsync repoSaveUpdateDeleteAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateDeleteAsync.SaveUpdateDeleteAsync<T1, T2, T3>(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateDeleteAsync<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateDeleteAsync repoSaveUpdateDeleteAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateDeleteAsync.SaveUpdateDeleteAsync<T1, T2, T3, T4>(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateDeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
          where T5 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateDeleteAsync repoSaveUpdateDeleteAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateDeleteAsync.SaveUpdateDeleteAsync<T1, T2, T3, T4, T5>(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion        
    }
}