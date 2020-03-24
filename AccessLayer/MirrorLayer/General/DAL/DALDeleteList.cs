using EFHelper;
using MirrorDB;
using System.Collections.Generic;
using MirrorLayer.General.Interface;
using System.Threading.Tasks;
using EFHelper.RepositoryDelete;

namespace MirrorLayer.General.DAL
{
    public class DALDeleteList : IDeleteList
    {
        private static DALDeleteList instance;
        public static DALDeleteList GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALDeleteList();
                return instance;
            }
        }

        #region Synchronous
        public bool DeleteList<T>(List<int> iDIdentity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T>(iDIdentity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2>(List<int> iDIdentity1, List<int> iDIdentity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2>(iDIdentity1, iDIdentity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2, T3>(List<int> iDIdentity1, List<int> iDIdentity2, List<int> iDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2, T3>(iDIdentity1, iDIdentity2, iDIdentity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2, T3, T4>(List<int> iDIdentity1, List<int> iDIdentity2, List<int> iDIdentity3, List<int> iDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2, T3, T4>(iDIdentity1, iDIdentity2, iDIdentity3, iDIdentity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2, T3, T4, T5>(List<int> iDIdentity1, List<int> iDIdentity2, List<int> iDIdentity3, List<int> iDIdentity4, List<int> iDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2, T3, T4, T5>(iDIdentity1, iDIdentity2, iDIdentity3, iDIdentity4, iDIdentity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T>(List<T> entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2>(List<T1> entity1, List<T2> entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteList<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteList repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteList<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion

        #region Asynchronous
        public async Task<bool> DeleteListAsync<T>(List<int> iDIdentity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T>(iDIdentity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2>(List<int> iDIdentity1, List<int> iDIdentity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2>(iDIdentity1, iDIdentity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2, T3>(List<int> iDIdentity1, List<int> iDIdentity2, List<int> iDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2, T3>(iDIdentity1, iDIdentity2, iDIdentity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2, T3, T4>(List<int> iDIdentity1, List<int> iDIdentity2, List<int> iDIdentity3, List<int> iDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2, T3, T4>(iDIdentity1, iDIdentity2, iDIdentity3, iDIdentity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2, T3, T4, T5>(List<int> iDIdentity1, List<int> iDIdentity2, List<int> iDIdentity3, List<int> iDIdentity4, List<int> iDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2, T3, T4, T5>(iDIdentity1, iDIdentity2, iDIdentity3, iDIdentity4, iDIdentity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T>(List<T> entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2>(List<T1> entity1, List<T2> entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteListAsync<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteListAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteListAsync<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion               
    }
}