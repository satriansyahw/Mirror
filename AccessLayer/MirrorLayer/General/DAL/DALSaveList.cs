using EFHelper;
using MirrorDB;
using System.Collections.Generic;
using MirrorLayer.General.Interface;
using System.Threading.Tasks;
using EFHelper.RepositorySave;

namespace MirrorLayer.General.DAL
{
    public class DALSaveList : ISaveList
    {
        private static DALSaveList instance;
        public static DALSaveList GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALSaveList();
                return instance;
            }
        }

        #region Synchronous
        public bool SaveList<T>(List<T> entity, out T identity) where T : class
        {
            bool @bool = false;
            @identity = null;
            InterfaceRepoSaveList repoSaveList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveList.SaveList<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @identity = (T)resultRepo.ReturnValue[0].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveList<T1, T2>(List<T1> entity1, List<T2> entity2, out T1 identity1, out T2 identity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            @identity1 = null;
            @identity2 = null;
            InterfaceRepoSaveList repoSaveList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveList.SaveList<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @identity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @identity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveList<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3, out T1 identity1, out T2 identity2, out T3 identity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            @identity1 = null;
            @identity2 = null;
            @identity3 = null;
            InterfaceRepoSaveList repoSaveList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveList.SaveList<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @identity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @identity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @identity3 = (T3)resultRepo.ReturnValue[2].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveList<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, out T1 identity1, out T2 identity2, out T3 identity3, out T4 identity4)
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
            InterfaceRepoSaveList repoSaveList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveList.SaveList<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
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
        public bool SaveList<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5, out T1 identity1, out T2 identity2, out T3 identity3, out T4 identity4, out T5 identity5)
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
            InterfaceRepoSaveList repoSaveList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveList.SaveList<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
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
        public async Task<bool> SaveListAsync<T>(List<T> entity) where T : class
        {
            bool @bool = false;
            InterfaceRepoSaveListAsync repoSaveListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveListAsync.SaveListAsync<T>(entity);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveListAsync<T1, T2>(List<T1> entity1, List<T2> entity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoSaveListAsync repoSaveListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveListAsync.SaveListAsync<T1, T2>(entity1, entity2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveListAsync<T1, T2, T3>(List<T1> entity1, List<T2> entity2, List<T3> entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoSaveListAsync repoSaveListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveListAsync.SaveListAsync<T1, T2, T3>(entity1, entity2, entity3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveListAsync<T1, T2, T3, T4>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            bool @bool = false;
            InterfaceRepoSaveListAsync repoSaveListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveListAsync.SaveListAsync<T1, T2, T3, T4>(entity1, entity2, entity3, entity4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveListAsync<T1, T2, T3, T4, T5>(List<T1> entity1, List<T2> entity2, List<T3> entity3, List<T4> entity4, List<T5> entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            bool @bool = false;
            InterfaceRepoSaveListAsync repoSaveListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveListAsync.SaveListAsync<T1, T2, T3, T4, T5>(entity1, entity2, entity3, entity4, entity5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion
    }
}