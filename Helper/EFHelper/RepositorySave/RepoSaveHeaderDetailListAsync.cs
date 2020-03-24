using EFHelper.ColumnHelper;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using EFHelper.RepositoryDelete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositorySave
{
    public  class RepoSaveHeaderDetailListAsync : InterfaceRepoSaveHeaderDetailListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoSaveHeaderDetailListAsync instance;
        public static RepoSaveHeaderDetailListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSaveHeaderDetailListAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1)
            where T : class
            where T1 : class
        {
            object objIDColumnHeader = null; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & listTblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader).ConfigureAwait(false); // Safe first in main table
                RepoSaveListAsync repoSaveList = new RepoSaveListAsync();
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<List<T1>>(listTblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        listTblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listTblDetail1);
                        var saveDetailTable = await repoSaveList.SaveListAsync<T1>(listTblDetail1).ConfigureAwait(false);
                        if (saveDetailTable.IsSuccessConnection & saveDetailTable.IsSuccessQuery)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listTblDetail1);
                        }
                        else
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader).ConfigureAwait(false);
                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            object objIDColumnHeader = null; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & listTblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader).ConfigureAwait(false); // Safe first in main table
                RepoSaveListAsync repoSaveList = new RepoSaveListAsync();
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {

                        ColumnPropSet.GetInstance.SetColValue<List<T1>>(listTblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T2>>(listTblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        
                        listTblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listTblDetail1);
                        listTblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listTblDetail2);
                        
                        var saveDetailTable = await repoSaveList.SaveListAsync<T1, T2>(listTblDetail1, listTblDetail2).ConfigureAwait(false);//save to T1 & others   
                        if (saveDetailTable.IsSuccessConnection & saveDetailTable.IsSuccessQuery)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listTblDetail1);
                        }
                        else
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader).ConfigureAwait(false);
                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3)
        where T : class
        where T1 : class
        where T2 : class
        where T3 : class
        {
            object objIDColumnHeader = null; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & listTblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader).ConfigureAwait(false); // Safe first in main table
                RepoSaveListAsync repoSaveList = new RepoSaveListAsync();
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<List<T1>>(listTblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T2>>(listTblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T3>>(listTblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails

                        listTblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listTblDetail1);
                        listTblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listTblDetail2);
                        listTblDetail3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listTblDetail3);

                        var saveDetailTable = await repoSaveList.SaveListAsync<T1, T2, T3>(listTblDetail1, listTblDetail2, listTblDetail3).ConfigureAwait(false);//save to T1 & others   
                        if (saveDetailTable.IsSuccessConnection & saveDetailTable.IsSuccessQuery)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listTblDetail1);
                        }
                        else
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader).ConfigureAwait(false);
                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {

            object objIDColumnHeader = null; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & listTblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader).ConfigureAwait(false); // Safe first in main table
                RepoSaveListAsync repoSaveList = new RepoSaveListAsync();
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<List<T1>>(listTblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T2>>(listTblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T3>>(listTblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T4>>(listTblDetail4, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails

                        listTblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listTblDetail1);
                        listTblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listTblDetail2);
                        listTblDetail3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listTblDetail3);
                        listTblDetail4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(listTblDetail4);
                        var saveDetailTable = await repoSaveList.SaveListAsync<T1, T2, T3, T4>(listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4).ConfigureAwait(false);//save to T1 & others   
                        if (saveDetailTable.IsSuccessConnection & saveDetailTable.IsSuccessQuery)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listTblDetail1);
                        }
                        else
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader).ConfigureAwait(false);
                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4, List<T5> listTblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {

            object objIDColumnHeader = null; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & listTblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader).ConfigureAwait(false); // Safe first in main table
                RepoSaveListAsync repoSaveList = new RepoSaveListAsync();
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<List<T1>>(listTblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T2>>(listTblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T3>>(listTblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T4>>(listTblDetail4, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<List<T5>>(listTblDetail5, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails

                        listTblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listTblDetail1);
                        listTblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listTblDetail2);
                        listTblDetail3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listTblDetail3);
                        listTblDetail4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(listTblDetail4);
                        listTblDetail5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(listTblDetail5);
                        var saveDetailTable = await repoSaveList.SaveListAsync<T1, T2, T3, T4, T5>(listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4, listTblDetail5).ConfigureAwait(false);//save to T1 & others   
                        if (saveDetailTable.IsSuccessConnection & saveDetailTable.IsSuccessQuery)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listTblDetail1);
                        }
                        else
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader).ConfigureAwait(false);
                        }
                    }


                }

            }
            return eFReturn;
        }
    }
}
