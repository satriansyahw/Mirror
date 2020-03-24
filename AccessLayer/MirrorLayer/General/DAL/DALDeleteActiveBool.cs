using EFHelper;
using MirrorDB;
using MirrorLayer.General.Interface;
using System.Threading.Tasks;
using EFHelper.RepositoryDelete;

namespace MirrorLayer.General.DAL
{
    public class DALDeleteActiveBool : IDeleteActiveBool
    {
        private static DALDeleteActiveBool instance;
        public static DALDeleteActiveBool GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALDeleteActiveBool();
                return instance;
            }
        }

        #region Synchronous         
        public bool DeleteActiveBool<T>(int IDIdentity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T>(IDIdentity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            { 
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1,T2>(IDIdentity1,IDIdentity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1, T2,T3>(IDIdentity1, IDIdentity2,IDIdentity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1, T2, T3,T4>(IDIdentity1, IDIdentity2, IDIdentity3,IDIdentity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T>(T entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1,T2>(entity1,entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1, T2, T3 , T4>(entity1, entity2, entity3,entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool DeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBool repoWrapper = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoWrapper.DeleteActiveBool<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion

        #region Asynchronous
        public async Task<bool> DeleteActiveBoolAsync<T>(int IDIdentity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T>(IDIdentity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2>(IDIdentity1, IDIdentity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T>(T entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoDeleteActiveBoolAsync repoWrapperAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoWrapperAsync.DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion
    }
}