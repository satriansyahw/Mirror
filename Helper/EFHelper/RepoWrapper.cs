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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper
{
    public class RepoWrapper: DBContextBantuan,InterfaceRepoSave, InterfaceRepoSaveList, InterfaceRepoSaveHeaderDetail, InterfaceRepoSaveHeaderDetailList, InterfaceRepoSaveUpdate, InterfaceRepoSaveUpdateList
        , InterfaceRepoUpdate, InterfaceRepoUpdateList, InterfaceRepoUpdateAll, InterfaceRepoUpdateAllList, InterfaceRepoDelete, InterfaceRepoDeleteList, InterfaceRepoDeleteActiveBool, InterfaceRepoDeleteActiveBoolList
        , InterfaceRepoDeleteHeaderDetail, InterfaceRepoDeleteHeaderDetailList, InterfaceRepoDeleteHeaderDetailActiveBool, InterfaceRepoDeleteHeaderDetailActiveBoolList
        , InterfaceRepoList, InterfaceRepoListQueryable, InterfaceRepoDeleteSave, InterfaceRepoDeleteSaveList, InterfaceRepoDeleteSaveActiveBool, InterfaceRepoDeleteSaveActiveBoolList
        , InterfaceRepoSaveUpdateDelete, InterfaceRepoSaveUpdateDeleteList, InterfaceRepoSaveUpdateDeleteActiveBool, InterfaceRepoSaveUpdateDeleteActiveBoolList
        ,InterfaceRepoListWithEmpInfo,InterfaceRepoListQueryableWithEmpInfo,InterfaceEFReturnValue
    {
        private static RepoWrapper instance;
        public new static RepoWrapper GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoWrapper();
                return instance;
            }
        }
        public RepoWrapper()
        {

        }
        public RepoWrapper(DbContext dbContext)
        {
            DBContextInfo.MyDbContext = dbContext;
        }
        public override DbContext CreateConnectionContext()
        {
            return base.CreateConnectionContext();
        }

        public override void SetConnectionContext(DbContext dbContext)
        {
            base.SetConnectionContext(dbContext);
        }
        public void IsUsingADODBCommandList(bool isTrue)
        {
            MiscClass.MiscClass.IsUsingADODBCommandList = true;
        }
        public EFReturnValue Delete<T>(int IDIdentity) where T : class
        {
            return RepoDelete.GetInstance.Delete<T>(IDIdentity);
        }

        public EFReturnValue Delete<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return RepoDelete.GetInstance.Delete<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public EFReturnValue Delete<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDelete.GetInstance.Delete<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public EFReturnValue Delete<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDelete.GetInstance.Delete<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public EFReturnValue Delete<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDelete.GetInstance.Delete<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public EFReturnValue Delete<T>(T entity) where T : class
        {
            return RepoDelete.GetInstance.Delete(entity);
        }

        public EFReturnValue Delete<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return RepoDelete.GetInstance.Delete(entity1, entity2);
        }

        public EFReturnValue Delete<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDelete.GetInstance.Delete(entity1, entity2, entity3);
        }

        public EFReturnValue Delete<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDelete.GetInstance.Delete(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue Delete<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDelete.GetInstance.Delete(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue DeleteActiveBool<T>(int IDIdentity) where T : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool<T>(IDIdentity);
        }

        public EFReturnValue DeleteActiveBool<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public EFReturnValue DeleteActiveBool<T>(T entity) where T : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool(entity);
        }

        public EFReturnValue DeleteActiveBool<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool(entity1, entity2);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool(entity1, entity2, entity3);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteActiveBool.GetInstance.DeleteActiveBool(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue DeleteActiveBoolList<T>(List<T> listEntity) where T : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList(listEntity);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList(listEntity1, listEntity2);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue DeleteActiveBoolList<T>(List<int> listIDIdentity) where T : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList<T>(listIDIdentity);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteActiveBoolList.GetInstance.DeleteActiveBoolList<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return RepoDeleteHeaderDetail.GetInstance.DeleteHeaderDetail<T, T1>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteHeaderDetail.GetInstance.DeleteHeaderDetail<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteHeaderDetail.GetInstance.DeleteHeaderDetail<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteHeaderDetail.GetInstance.DeleteHeaderDetail<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteHeaderDetail.GetInstance.DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return RepoDeleteHeaderDetailActiveBool.GetInstance.DeleteHeaderDetailActiveBool<T, T1>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteHeaderDetailActiveBool.GetInstance.DeleteHeaderDetailActiveBool<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteHeaderDetailActiveBool.GetInstance.DeleteHeaderDetailActiveBool<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteHeaderDetailActiveBool.GetInstance.DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteHeaderDetailActiveBool.GetInstance.DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return RepoDeleteHeaderDetailActiveBoolList.GetInstance.DeleteHeaderDetailActiveBoolList<T, T1>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteHeaderDetailActiveBoolList.GetInstance.DeleteHeaderDetailActiveBoolList<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteHeaderDetailActiveBoolList.GetInstance.DeleteHeaderDetailActiveBoolList<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteHeaderDetailActiveBoolList.GetInstance.DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteHeaderDetailActiveBoolList.GetInstance.DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return RepoDeleteHeaderDetailList.GetInstance.DeleteHeaderDetailList<T, T1>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteHeaderDetailList.GetInstance.DeleteHeaderDetailList<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteHeaderDetailList.GetInstance.DeleteHeaderDetailList<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteHeaderDetailList.GetInstance.DeleteHeaderDetailList<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteHeaderDetailList.GetInstance.DeleteHeaderDetailList<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteList<T>(List<T> listEntity) where T : class
        {
            return RepoDeleteList.GetInstance.DeleteList(listEntity);
        }

        public EFReturnValue DeleteList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return RepoDeleteList.GetInstance.DeleteList(listEntity1, listEntity2);
        }

        public EFReturnValue DeleteList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteList.GetInstance.DeleteList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteList.GetInstance.DeleteList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteList.GetInstance.DeleteList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue DeleteList<T>(List<int> listIDIdentity) where T : class
        {
            return RepoDeleteList.GetInstance.DeleteList<T>(listIDIdentity);
        }

        public EFReturnValue DeleteList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return RepoDeleteList.GetInstance.DeleteList<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public EFReturnValue DeleteList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteList.GetInstance.DeleteList<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteList.GetInstance.DeleteList<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteList.GetInstance.DeleteList<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public EFReturnValue ListData<T>(List<SearchField> searchFieldList) where T : class
        {
            return RepoList.GetInstance.ListData<T>(searchFieldList);
        }

        public EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            return RepoList.GetInstance.ListData<T>(searchFieldList, sortColumn, isAscending, topTake);
        }

        public EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            return RepoList.GetInstance.ListData<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake);
        }
      
        public EFReturnValue Save<T>(T entity) where T : class
        {
            return RepoSave.GetInstance.Save(entity);
        }

        public EFReturnValue Save<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class     where T2 : class
        {
            return RepoSave.GetInstance.Save(entity1, entity2);
        }

        public EFReturnValue Save<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSave.GetInstance.Save(entity1, entity2, entity3);
        }

        public EFReturnValue Save<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSave.GetInstance.Save(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue Save<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSave.GetInstance.Save(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1)
            where T : class
            where T1 : class
        {
            return RepoSaveHeaderDetail.GetInstance.SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return RepoSaveHeaderDetail.GetInstance.SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveHeaderDetail.GetInstance.SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveHeaderDetail.GetInstance.SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveHeaderDetail.GetInstance.SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1)
            where T : class
            where T1 : class
        {
            return RepoSaveHeaderDetailList.GetInstance.SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return RepoSaveHeaderDetailList.GetInstance.SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveHeaderDetailList.GetInstance.SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveHeaderDetailList.GetInstance.SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4, List<T5> listTblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveHeaderDetailList.GetInstance.SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4, listTblDetail5);
        }

        public EFReturnValue SaveList<T>(List<T> listEntity) where T : class
        {
            return RepoSaveList.GetInstance.SaveList(listEntity);
        }

        public EFReturnValue SaveList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveList.GetInstance.SaveList(listEntity1, listEntity2);
        }

        public EFReturnValue SaveList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveList.GetInstance.SaveList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue SaveList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveList.GetInstance.SaveList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue SaveList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveList.GetInstance.SaveList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue SaveUpdate<T1>(T1 entity1, bool isSaveT1) where T1 : class
        {
            return RepoSaveUpdate.GetInstance.SaveUpdate(entity1, isSaveT1);
        }

        public EFReturnValue SaveUpdate<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdate.GetInstance.SaveUpdate(entity1, isSaveT1, entity2, isSaveT2);
        }

        public EFReturnValue SaveUpdate<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdate.GetInstance.SaveUpdate(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3);
        }

        public EFReturnValue SaveUpdate<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdate.GetInstance.SaveUpdate(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4);
        }

        public EFReturnValue SaveUpdate<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdate.GetInstance.SaveUpdate(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5);
        }

        public EFReturnValue SaveUpdateList<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class
        {
            return RepoSaveUpdateList.GetInstance.SaveUpdateList(listEntity1, isSaveT1);
        }

        public EFReturnValue SaveUpdateList<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateList.GetInstance.SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2);
        }

        public EFReturnValue SaveUpdateList<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateList.GetInstance.SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3);
        }

        public EFReturnValue SaveUpdateList<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateList.GetInstance.SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4);
        }

        public EFReturnValue SaveUpdateList<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateList.GetInstance.SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4, listEntity5, isSaveT5);
        }

        public EFReturnValue Update<T>(T entity) where T : class
        {
            return RepoUpdate.GetInstance.Update(entity);
        }

        public EFReturnValue Update<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return RepoUpdate.GetInstance.Update(entity1, entity2);
        }

        public EFReturnValue Update<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoUpdate.GetInstance.Update(entity1, entity2, entity3);
        }

        public EFReturnValue Update<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoUpdate.GetInstance.Update(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue Update<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoUpdate.GetInstance.Update(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue UpdateAll<T>(T entity) where T : class
        {
            return RepoUpdateAll.GetInstance.UpdateAll(entity);
        }

        public EFReturnValue UpdateAll<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return RepoUpdateAll.GetInstance.UpdateAll(entity1, entity2);
        }

        public EFReturnValue UpdateAll<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoUpdateAll.GetInstance.UpdateAll(entity1, entity2, entity3);
        }

        public EFReturnValue UpdateAll<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoUpdateAll.GetInstance.UpdateAll(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue UpdateAll<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoUpdateAll.GetInstance.UpdateAll(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue UpdateAllList<T>(List<T> listEntity) where T : class
        {
            return RepoUpdateAllList.GetInstance.UpdateAllList(listEntity);
        }

        public EFReturnValue UpdateAllList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return RepoUpdateAllList.GetInstance.UpdateAllList(listEntity1, listEntity2);
        }

        public EFReturnValue UpdateAllList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoUpdateAllList.GetInstance.UpdateAllList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue UpdateAllList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoUpdateAllList.GetInstance.UpdateAllList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue UpdateAllList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoUpdateAllList.GetInstance.UpdateAllList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue UpdateList<T>(List<T> listlistEntity) where T : class
        {
            return RepoUpdateList.GetInstance.UpdateList(listlistEntity);
        }

        public EFReturnValue UpdateList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return RepoUpdateList.GetInstance.UpdateList(listEntity1, listEntity2);
        }

        public EFReturnValue UpdateList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoUpdateList.GetInstance.UpdateList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue UpdateList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoUpdateList.GetInstance.UpdateList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue UpdateList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoUpdateList.GetInstance.UpdateList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue ListData<T>() where T : class
        {
            return RepoList.GetInstance.ListData<T>();
        }

        public EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable) where TResult : class
        {
            return RepoListQueryable.GetInstance.ListDataQueryable(queryable);
        }

        public EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList) where TResult : class
        {
            return RepoListQueryable.GetInstance.ListDataQueryable(queryable, searchFieldList);
        }

        public EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class
        {
            return RepoListQueryable.GetInstance.ListDataQueryable(queryable, searchFieldList, sortColumn, isAscending, topTake);
        }

        public EFReturnValue DeleteSave<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSave.GetInstance.DeleteSave<TDelete, T1>(deleteParameters, entitySave1);
        }

        public EFReturnValue DeleteSave<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSave.GetInstance.DeleteSave<TDelete, T1, T2>(deleteParameters, entitySave1, entitySave2);
        }

        public EFReturnValue DeleteSave<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSave.GetInstance.DeleteSave<TDelete, T1, T2, T3>(deleteParameters, entitySave1, entitySave2, entitySave3);
        }

        public EFReturnValue DeleteSave<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSave.GetInstance.DeleteSave<TDelete, T1, T2, T3, T4>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4);
        }

        public EFReturnValue DeleteSave<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSave.GetInstance.DeleteSave<TDelete, T1, T2, T3, T4, T5>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4, entitySave5);
        }

        public EFReturnValue DeleteSaveList<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSaveList.GetInstance.DeleteSaveList<TDelete, T1>(deleteParameters, listEntitySave1);
        }

        public EFReturnValue DeleteSaveList<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSaveList.GetInstance.DeleteSaveList<TDelete, T1, T2>(deleteParameters, listEntitySave1, listEntitySave2);
        }

        public EFReturnValue DeleteSaveList<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSaveList.GetInstance.DeleteSaveList<TDelete, T1, T2, T3>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3);
        }

        public EFReturnValue DeleteSaveList<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSaveList.GetInstance.DeleteSaveList<TDelete, T1, T2, T3, T4>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4);
        }

        public EFReturnValue DeleteSaveList<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSaveList.GetInstance.DeleteSaveList<TDelete, T1, T2, T3, T4, T5>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4, listEntitySave5);
        }

        public EFReturnValue DeleteSaveActiveBool<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSaveActiveBool.GetInstance.DeleteSaveActiveBool<TDelete, T1>(deleteParameters, entitySave1);
        }

        public EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSaveActiveBool.GetInstance.DeleteSaveActiveBool<TDelete, T1, T2>(deleteParameters, entitySave1, entitySave2);
        }

        public EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSaveActiveBool.GetInstance.DeleteSaveActiveBool<TDelete, T1, T2, T3>(deleteParameters, entitySave1, entitySave2, entitySave3);
        }

        public EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSaveActiveBool.GetInstance.DeleteSaveActiveBool<TDelete, T1, T2, T3, T4>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4);
        }

        public EFReturnValue DeleteSaveActiveBool<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSaveActiveBool.GetInstance.DeleteSaveActiveBool<TDelete, T1, T2, T3, T4, T5>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4, entitySave5);
        }

        public EFReturnValue DeleteSaveActiveBoolList<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSaveActiveBoolList.GetInstance.DeleteSaveActiveBoolList<TDelete, T1>(deleteParameters, listEntitySave1);
        }

        public EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSaveActiveBoolList.GetInstance.DeleteSaveActiveBoolList<TDelete, T1, T2>(deleteParameters, listEntitySave1, listEntitySave2);
        }

        public EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSaveActiveBoolList.GetInstance.DeleteSaveActiveBoolList<TDelete, T1, T2, T3>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3);
        }

        public EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSaveActiveBoolList.GetInstance.DeleteSaveActiveBoolList<TDelete, T1, T2, T3, T4>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4);
        }

        public EFReturnValue DeleteSaveActiveBoolList<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSaveActiveBoolList.GetInstance.DeleteSaveActiveBoolList<TDelete, T1, T2, T3, T4, T5>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4, listEntitySave5);
        }

        public EFReturnValue SaveUpdateDelete<T1>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDelete.GetInstance.SaveUpdateDelete(entity1, enumSUDT1);
        }

        public EFReturnValue SaveUpdateDelete<T1, T2>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDelete.GetInstance.SaveUpdateDelete(entity1, enumSUDT1, entity2, enumSUDT2);
        }

        public EFReturnValue SaveUpdateDelete<T1, T2, T3>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDelete.GetInstance.SaveUpdateDelete(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3);
        }

        public EFReturnValue SaveUpdateDelete<T1, T2, T3, T4>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDelete.GetInstance.SaveUpdateDelete(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4);
        }

        public EFReturnValue SaveUpdateDelete<T1, T2, T3, T4, T5>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, T5 entity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDelete.GetInstance.SaveUpdateDelete(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5);
        }

        public EFReturnValue SaveUpdateDeleteList<T1>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDeleteList.GetInstance.SaveUpdateDeleteList(listEntity1, enumSUDT1);
        }

        public EFReturnValue SaveUpdateDeleteList<T1, T2>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDeleteList.GetInstance.SaveUpdateDeleteList(listEntity1, enumSUDT1, listEntity2, enumSUDT2);
        }

        public EFReturnValue SaveUpdateDeleteList<T1, T2, T3>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDeleteList.GetInstance.SaveUpdateDeleteList(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3);
        }

        public EFReturnValue SaveUpdateDeleteList<T1, T2, T3, T4>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDeleteList.GetInstance.SaveUpdateDeleteList(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4);
        }

        public EFReturnValue SaveUpdateDeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDeleteList.GetInstance.SaveUpdateDeleteList(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4, listEntity5, enumSUDT5);
        }

        public EFReturnValue SaveUpdateDeleteActiveBool<T1>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDeleteActiveBool.GetInstance.SaveUpdateDeleteActiveBool(entity1, enumSUDT1);
        }

        public EFReturnValue SaveUpdateDeleteActiveBool<T1, T2>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDeleteActiveBool.GetInstance.SaveUpdateDeleteActiveBool(entity1, enumSUDT1, entity2, enumSUDT2);
        }

        public EFReturnValue SaveUpdateDeleteActiveBool<T1, T2, T3>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDeleteActiveBool.GetInstance.SaveUpdateDeleteActiveBool(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3);
        }

        public EFReturnValue SaveUpdateDeleteActiveBool<T1, T2, T3, T4>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDeleteActiveBool.GetInstance.SaveUpdateDeleteActiveBool(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4);
        }

        public EFReturnValue SaveUpdateDeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, T5 entity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDeleteActiveBool.GetInstance.SaveUpdateDeleteActiveBool(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5);
        }

        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDeleteActiveBoolList.GetInstance.SaveUpdateDeleteActiveBoolList(listEntity1, enumSUDT1);
        }

        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDeleteActiveBoolList.GetInstance.SaveUpdateDeleteActiveBoolList(listEntity1, enumSUDT1, listEntity2, enumSUDT2);
        }

        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDeleteActiveBoolList.GetInstance.SaveUpdateDeleteActiveBoolList(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3);
        }

        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDeleteActiveBoolList.GetInstance.SaveUpdateDeleteActiveBoolList(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4);
        }

        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDeleteActiveBoolList.GetInstance.SaveUpdateDeleteActiveBoolList(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4, listEntity5, enumSUDT5);
        }

        public EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)     
             where T : class where TNoToName : class, IConvertNoToName
        {
            return RepoListWithEmpInfo.GetInstance.ListDataWithEmpInfo<T, TNoToName>(listTableConvert, listColumnConvert);
        }

        public EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
             where T : class where TNoToName : class, IConvertNoToName
        {
            return RepoListWithEmpInfo.GetInstance.ListDataWithEmpInfo<T, TNoToName>(listTableConvert, listColumnConvert, searchFieldList);
        }

        public EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
             where T : class where TNoToName : class, IConvertNoToName
        {
            return RepoListWithEmpInfo.GetInstance.ListDataWithEmpInfo<T, TNoToName>(listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake);
        }

        public EFReturnValue ListDataWithEmpInfo<TSource, TResult, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
             where TSource : class where TResult:class where TNoToName : class, IConvertNoToName
        {
            return RepoListWithEmpInfo.GetInstance.ListDataWithEmpInfo<TSource, TResult, TNoToName>(listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake);
        }

        public EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
             where TResult : class where TNoToName : class, IConvertNoToName
        {
            return RepoListQueryableWithEmpInfo.GetInstance.ListDataQueryableWithEmpInfo(queryable, listTableConvert, listColumnConvert);
        }

        public EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
             where TResult : class where TNoToName : class, IConvertNoToName
        {
            return RepoListQueryableWithEmpInfo.GetInstance.ListDataQueryableWithEmpInfo(queryable, listTableConvert, listColumnConvert, searchFieldList);
        }

        public EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TResult : class where TNoToName : class, IConvertNoToName
        {
            return RepoListQueryableWithEmpInfo.GetInstance.ListDataQueryableWithEmpInfo(queryable, listTableConvert, listColumnConvert, searchFieldList, sortColumn, isAscending, topTake);
        }
        public List<T> ConvertDataToListEmpInfo<T, TNoToName>(List<T> listDataWantToConverted, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where T : class  where TNoToName : class, IConvertNoToName
        {
            RepoListMiscHelper repoListMisc = new RepoListMiscHelper();
            return repoListMisc.ConvertDataToListEmpInfo<T, TNoToName>(listDataWantToConverted, listTableConvert, listColumnConvert);
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
