using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryDelete;
using EFHelper.RepositoryDeleteHeaderDetail;
using EFHelper.RepositoryDeleteSave;
using EFHelper.RepositoryList;
using EFHelper.RepositorySave;
using EFHelper.RepositorySaveUpdate;
using EFHelper.RepositorySaveUpdateDelete;
using EFHelper.RepositoryUpdate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFHelper
{
    public class RepoWrapperAsync : DBContextBantuan,InterfaceRepoSaveAsync, InterfaceRepoSaveListAsync, InterfaceRepoSaveHeaderDetailAsync, InterfaceRepoSaveHeaderDetailListAsync, InterfaceRepoSaveUpdateAsync, InterfaceRepoSaveUpdateListAsync
        , InterfaceRepoUpdateAsync, InterfaceRepoUpdateListAsync, InterfaceRepoUpdateAllAsync, InterfaceRepoUpdateAllListAsync, InterfaceRepoDeleteAsync, InterfaceRepoDeleteListAsync, InterfaceRepoDeleteActiveBoolAsync, InterfaceRepoDeleteActiveBoolListAsync
        , InterfaceRepoDeleteHeaderDetailAsync, InterfaceRepoDeleteHeaderDetailListAsync, InterfaceRepoDeleteHeaderDetailActiveBoolAsync, InterfaceRepoDeleteHeaderDetailActiveBoolListAsync
        , InterfaceRepoListAsync, InterfaceRepoListQueryableAsync, InterfaceRepoDeleteSaveAsync, InterfaceRepoDeleteSaveListAsync, InterfaceRepoDeleteSaveActiveBoolAsync, InterfaceRepoDeleteSaveActiveBoolListAsync
        , InterfaceRepoSaveUpdateDeleteAsync, InterfaceRepoSaveUpdateDeleteListAsync, InterfaceRepoSaveUpdateDeleteActiveBoolAsync, InterfaceRepoSaveUpdateDeleteActiveBoolListAsync
         , InterfaceRepoListWithEmpInfoAsync, InterfaceRepoListQueryableWithEmpInfoAsync, InterfaceEFReturnValue
    {
        private static RepoWrapperAsync instance;
        private readonly RepoListMiscHelper repoListMisc = new RepoListMiscHelper();
        public new static RepoWrapperAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoWrapperAsync();
                return instance;
            }
        }
        public RepoWrapperAsync()
        {

        }
        public RepoWrapperAsync(DbContext dbContext)
        {
            DBContextInfo.MyDbContext = dbContext;
        }
        public override void SetConnectionContext(DbContext dbContext)
        {
            base.SetConnectionContext(dbContext);
        }
        public override DbContext CreateConnectionContext()
        {
            return base.CreateConnectionContext();
        }
        public async Task IsUsingADODBCommandListAsync(bool isTrue)
        {
            await Task.Run(() =>
            {
                MiscClass.MiscClass.IsUsingADODBCommandList = true;
            });
        }
        public async Task<EFReturnValue> DeleteActiveBoolAsync<T>(T entity) where T : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2).ConfigureAwait(false);
        }
       
        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2, entity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2, entity3, entity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2, entity3, entity4, entity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T>(int IDIdentity) where T : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T>(IDIdentity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2>(IDIdentity1, IDIdentity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3, listEntity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<int> listIDIdentity) where T : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T>(listIDIdentity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2>(listIDIdentity1, listIDIdentity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T>(int IDIdentity) where T : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T>(IDIdentity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2>(IDIdentity1, IDIdentity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T>(T entity) where T : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2, entity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2, entity3, entity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2, entity3, entity4, entity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2, T3>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2, T3>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2, listEntity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2, listEntity3, listEntity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T>(List<int> listIDIdentity) where T : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T>(listIDIdentity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2>(listIDIdentity1, listIDIdentity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<T>(searchFieldList).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<T>(searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
        }
        public async Task<EFReturnValue> ListDataAsync<T>() where T : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<T>().ConfigureAwait(false);
        }
        public async Task<EFReturnValue> SaveAsync<T>(T entity) where T : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2, entity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2, entity3, entity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2, entity3, entity4, entity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1)
            where T : class
            where T1 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1)
            where T : class
            where T1 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4, List<T5> listTblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4, listTblDetail5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2, listEntity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2, listEntity3, listEntity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1>(T1 entity1, bool isSaveT1) where T1 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4, listEntity5, isSaveT5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T>(T entity) where T : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2, entity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2, entity3, entity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2, entity3, entity4, entity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2, listEntity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2, listEntity3, listEntity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAsync<T>(T entity) where T : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2, entity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2, entity3, entity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2, entity3, entity4, entity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateListAsync<T>(List<T> listlistEntity) where T : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listlistEntity).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2, listEntity3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2, listEntity3, listEntity4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable) where TResult : class
        {
            return await RepoListQueryableAsync.GetInstance.ListDataQueryableAsync(queryable).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList) where TResult : class
        {
            return await RepoListQueryableAsync.GetInstance.ListDataQueryableAsync(queryable, searchFieldList).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class
        {
            return await RepoListQueryableAsync.GetInstance.ListDataQueryableAsync(queryable, searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
            where TDelete : class
            where T1 : class
        {
            return await RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1>(deleteParameters, listEntitySave1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2>(deleteParameters, listEntitySave1, listEntitySave2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2, T3>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2, T3, T4>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4, listEntitySave5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveAsync<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class
            where T1 : class
        {
            return await RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1>(deleteParameters, entitySave1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2>(deleteParameters, entitySave1, entitySave2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2, T3>(deleteParameters, entitySave1, entitySave2, entitySave3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2, T3, T4>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4, entitySave5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class
            where T1 : class
        {
            return await RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1>(deleteParameters, entitySave1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2>(deleteParameters, entitySave1, entitySave2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3>(deleteParameters, entitySave1, entitySave2, entitySave3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4, entitySave5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
            where TDelete : class
            where T1 : class
        {
            return await RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1>(deleteParameters, listEntitySave1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2>(deleteParameters, listEntitySave1, listEntitySave2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4, listEntitySave5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteAsync<T1>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return await RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3, T4>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, T5 entity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteListAsync<T1>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return await RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4, listEntity5, enumSUDT5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, T5 entity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4, listEntity5, enumSUDT5).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
              where T : class where TNoToName : class, IConvertNoToName
        {
            return await RepoListWithEmpInfoAsync.GetInstance.ListDataWithEmpInfoAsync<T, TNoToName>(listTableConvert, listColumnConvert).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
              where T : class where TNoToName : class, IConvertNoToName
        {
            return await RepoListWithEmpInfoAsync.GetInstance.ListDataWithEmpInfoAsync<T, TNoToName>(listTableConvert, listColumnConvert, searchFieldList).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
              where T : class where TNoToName : class, IConvertNoToName
        {
            return await RepoListWithEmpInfoAsync.GetInstance.ListDataWithEmpInfoAsync<T, TNoToName>(listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataWithEmpInfoAsync<TSource, TResult, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
              where TSource : class where TResult : class where TNoToName : class, IConvertNoToName
        {
            return await RepoListWithEmpInfoAsync.GetInstance.ListDataWithEmpInfoAsync<TSource, TResult, TNoToName>(listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataQueryableWithEmpInfoAsync<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where TResult : class where TNoToName : class, IConvertNoToName
        {
            return await RepoListQueryableWithEmpInfoAsync.GetInstance.ListDataQueryableWithEmpInfoAsync(queryable, listTableConvert, listColumnConvert).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataQueryableWithEmpInfoAsync<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
            where TResult : class where TNoToName : class, IConvertNoToName
        {
            return await RepoListQueryableWithEmpInfoAsync.GetInstance.ListDataQueryableWithEmpInfoAsync(queryable, listTableConvert, listColumnConvert, searchFieldList).ConfigureAwait(false);
        }

        public async Task<EFReturnValue> ListDataQueryableWithEmpInfoAsync<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TResult : class where TNoToName : class, IConvertNoToName
        {
            return await RepoListQueryableWithEmpInfoAsync.GetInstance.ListDataQueryableWithEmpInfoAsync(queryable, listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake).ConfigureAwait(false);
        }
        public async Task<List<T>> ConvertDataToListEmpInfoAsync<T, TNoToName>(List<T> listDataWantToConverted, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
          where T : class where TNoToName : class, IConvertNoToName
        {
            List<T> result = null;
            await Task.Run(() =>
            {
                
                result = repoListMisc.ConvertDataToListEmpInfo<T, TNoToName>(listDataWantToConverted, listTableConvert, listColumnConvert);

            });
            return result;
        }
        public List<T> ConvertReturnValueToList<T>(EFReturnValue returnValue) where T : class
        {
            return EFReturnValue.GetInstance.ConvertReturnValueToList<T>(returnValue);
        }

        public T ConvertReturnValueToClass<T>(EFReturnValue returnValue) where T : class
        {
            return EFReturnValue.GetInstance.ConvertReturnValueToClass<T>(returnValue);
        }

        public bool ConvertReturnValueToBool(EFReturnValue returnValue)
        {
            return EFReturnValue.GetInstance.ConvertReturnValueToBool(returnValue);
        }
    }
}
