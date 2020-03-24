using EFHelper;
using MirrorDB;
using MirrorLayer.General.Interface;
using System.Threading.Tasks;
using EFHelper.RepositoryUpdate;

namespace MirrorLayer.General.DAL
{
    public class DALUpdate : IUpdate
    {
        private static DALUpdate instance;
        public static DALUpdate GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALUpdate();
                return instance;
            }
        }

        #region Synchronous
        public bool Update<T>(T entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoUpdate repoUpdate = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdate.Update<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool Update<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoUpdate repoUpdate = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdate.Update<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool Update<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoUpdate repoUpdate = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdate.Update<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool Update<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoUpdate repoUpdate = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdate.Update<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool Update<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoUpdate repoUpdate = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdate.Update<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion

        #region Asynchronous
        public async Task<bool> UpdateAsync<T>(T entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAsync repoUpdateAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAsync.UpdateAsync<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAsync repoUpdateAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAsync.UpdateAsync<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAsync repoUpdateAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAsync.UpdateAsync<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAsync repoUpdateAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAsync.UpdateAsync<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAsync repoUpdateAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAsync.UpdateAsync<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion
    }
}