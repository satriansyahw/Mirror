using EFHelper;
using EFHelper.RepositoryUpdate;
using MirrorDB;
using MirrorLayer.General.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MirrorLayer.General.DAL
{
    public class DALUpdateAllList : IUpdateAllList
    {
        private static DALUpdateAllList instance;
        public static DALUpdateAllList GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALUpdateAllList();
                return instance;
            }
        }

        #region Synchronous
        public bool UpdateAllList<T>(List<T> entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllList repoUpdateAllList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdateAllList.UpdateAllList<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool UpdateAllList<T1, T2>(List<T1> entity1, List<T2> entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllList repoUpdateAllList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdateAllList.UpdateAllList<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool UpdateAllList<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllList repoUpdateAllList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdateAllList.UpdateAllList<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool UpdateAllList<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllList repoUpdateAllList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdateAllList.UpdateAllList<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool UpdateAllList<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllList repoUpdateAllList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoUpdateAllList.UpdateAllList<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion

        #region Asynchronous
        public async Task<bool> UpdateAllListAsync<T>(List<T> entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllListAsync repoUpdateAllListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAllListAsync.UpdateAllListAsync<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAllListAsync<T1, T2>(List<T1> entity1, List<T2> entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllListAsync repoUpdateAllListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAllListAsync.UpdateAllListAsync<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAllListAsync<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllListAsync repoUpdateAllListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAllListAsync.UpdateAllListAsync<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAllListAsync<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllListAsync repoUpdateAllListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAllListAsync.UpdateAllListAsync<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> UpdateAllListAsync<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoUpdateAllListAsync repoUpdateAllListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoUpdateAllListAsync.UpdateAllListAsync<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion
    }
}