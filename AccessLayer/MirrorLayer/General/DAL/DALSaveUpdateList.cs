using EFHelper;
using EFHelper.RepositorySaveUpdate;
using MirrorDB; 
using MirrorLayer.General.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MirrorLayer.General.DAL
{
    public class DALSaveUpdateList : ISaveUpdateList
    {
        private static DALSaveUpdateList instance;
        public static DALSaveUpdateList GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DALSaveUpdateList();
                return instance;
            }
        }

        #region Synchronous
        public bool SaveUpdateList<T>(List<T> entity, bool isSaveT, out T @identity) where T : class
        {
            bool @bool = false;
            @identity = null;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T>(entity, isSaveT);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                identity = (T)resultRepo.ReturnValue[0].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateList<T1, T2>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, out T1 @resultEntity1, out T2 @resultEntity2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            @resultEntity1 = null;
            @resultEntity2 = null;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2>(entity1, isSaveT1, entity2, isSaveT2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @resultEntity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @resultEntity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateList<T1, T2, T3>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, out T1 @identity1, out T2 @identity2, out T3 @identity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            @identity1 = null;
            @identity2 = null;
            @identity3 = null;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2, T3>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @identity1 = (T1)resultRepo.ReturnValue[0].ReturnValue;
                @identity2 = (T2)resultRepo.ReturnValue[1].ReturnValue;
                @identity3 = (T3)resultRepo.ReturnValue[2].ReturnValue;
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateList<T1, T2, T3, T4>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4)
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
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2, T3, T4>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4);
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
        public bool SaveUpdateList<T1, T2, T3, T4, T5>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, List<T5> entity5, bool isSaveT5, out T1 @identity1, out T2 @identity2, out T3 @identity3, out T4 @identity4, out T5 @identity5)
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
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2, T3, T4, T5>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5);
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

        public bool SaveUpdateList<T>(List<T> entity, bool isSaveT) where T : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T>(entity, isSaveT);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateList<T1, T2>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2>(entity1, isSaveT1, entity2, isSaveT2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateList<T1, T2, T3>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2, T3>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateList<T1, T2, T3, T4>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2, T3, T4>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public bool SaveUpdateList<T1, T2, T3, T4, T5>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, List<T5> entity5, bool isSaveT5)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
          where T5 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateList repoSaveUpdateList = new RepoWrapper(new MirrorDBContext());
            var resultRepo = repoSaveUpdateList.SaveUpdateList<T1, T2, T3, T4, T5>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion

        #region Asynchronous
        public async Task<bool> SaveUpdateListAsync<T>(List<T> entity, bool isSaveT) where T : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateListAsync repoSaveUpdateListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateListAsync.SaveUpdateListAsync<T>(entity, isSaveT);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateListAsync<T1, T2>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateListAsync repoSaveUpdateListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateListAsync.SaveUpdateListAsync<T1, T2>(entity1, isSaveT1, entity2, isSaveT2);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateListAsync<T1, T2, T3>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateListAsync repoSaveUpdateListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateListAsync.SaveUpdateListAsync<T1, T2, T3>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateListAsync<T1, T2, T3, T4>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateListAsync repoSaveUpdateListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateListAsync.SaveUpdateListAsync<T1, T2, T3, T4>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        public async Task<bool> SaveUpdateListAsync<T1, T2, T3, T4, T5>(List<T1> entity1, bool isSaveT1, List<T2> entity2, bool isSaveT2, List<T3> entity3, bool isSaveT3, List<T4> entity4, bool isSaveT4, List<T5> entity5, bool isSaveT5)
          where T1 : class
          where T2 : class
          where T3 : class
          where T4 : class
          where T5 : class
        {
            bool @bool = false;
            InterfaceRepoSaveUpdateListAsync repoSaveUpdateListAsync = new RepoWrapperAsync(new MirrorDBContext());
            var resultRepo = await repoSaveUpdateListAsync.SaveUpdateListAsync<T1, T2, T3, T4, T5>(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5);
            if (resultRepo.IsSuccessConnection & resultRepo.IsSuccessQuery)
            {
                @bool = true;
            }
            return @bool;
        }
        #endregion
    }
}