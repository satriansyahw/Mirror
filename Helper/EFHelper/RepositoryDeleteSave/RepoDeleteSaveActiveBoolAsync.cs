using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using Microsoft.EntityFrameworkCore;

namespace EFHelper.RepositoryDeleteSave
{
    public class RepoDeleteSaveActiveBoolAsync : InterfaceRepoDeleteSaveActiveBoolAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteSaveActiveBoolAsync instance;
        public static RepoDeleteSaveActiveBoolAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteSaveActiveBoolAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class
            where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entitySave1 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            entitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entitySave1);

                            listDelete = EntityPreparationBantuan.GetInstance.DictEntityPreparation["deleteactivebool"].SetPreparationEntity<TDelete>(listDelete);
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayActiveBool);
                            context.Set<TDelete>().AttachRange(listDelete);
                            context.Entry(listDelete).State = EntityState.Unchanged;
                            if (propUpdateDate != null) context.Entry(listDelete).Property(propUpdateDate.Name).IsModified = true;
                            if (propActiveBool != null) context.Entry(listDelete).Property(propActiveBool.Name).IsModified = true;

                            context.Set<T1>().Add(entitySave1);

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, entitySave1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entitySave1 != null & entitySave2 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            entitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entitySave1);
                            entitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entitySave2);

                            listDelete = EntityPreparationBantuan.GetInstance.DictEntityPreparation["deleteactivebool"].SetPreparationEntity<TDelete>(listDelete);
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayActiveBool);
                            context.Set<TDelete>().AttachRange(listDelete);
                            context.Entry(listDelete).State = EntityState.Unchanged;
                            if (propUpdateDate != null) context.Entry(listDelete).Property(propUpdateDate.Name).IsModified = true;
                            if (propActiveBool != null) context.Entry(listDelete).Property(propActiveBool.Name).IsModified = true;

                            context.Set<T1>().Add(entitySave1);
                            context.Set<T2>().Add(entitySave2);

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, entitySave1, entitySave2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entitySave1 != null & entitySave2 != null & entitySave3 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            entitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entitySave1);
                            entitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entitySave2);
                            entitySave3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entitySave3);

                            listDelete = EntityPreparationBantuan.GetInstance.DictEntityPreparation["deleteactivebool"].SetPreparationEntity<TDelete>(listDelete);
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayActiveBool);
                            context.Set<TDelete>().AttachRange(listDelete);
                            context.Entry(listDelete).State = EntityState.Unchanged;
                            if (propUpdateDate != null) context.Entry(listDelete).Property(propUpdateDate.Name).IsModified = true;
                            if (propActiveBool != null) context.Entry(listDelete).Property(propActiveBool.Name).IsModified = true;

                            context.Set<T1>().Add(entitySave1);
                            context.Set<T2>().Add(entitySave2);
                            context.Set<T3>().Add(entitySave3);

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, entitySave1, entitySave2, entitySave3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entitySave1 != null & entitySave2 != null & entitySave3 != null & entitySave4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            entitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entitySave1);
                            entitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entitySave2);
                            entitySave3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entitySave3);
                            entitySave4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entitySave4);

                            listDelete = EntityPreparationBantuan.GetInstance.DictEntityPreparation["deleteactivebool"].SetPreparationEntity<TDelete>(listDelete);
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayActiveBool);
                            context.Set<TDelete>().AttachRange(listDelete);
                            context.Entry(listDelete).State = EntityState.Unchanged;
                            if (propUpdateDate != null) context.Entry(listDelete).Property(propUpdateDate.Name).IsModified = true;
                            if (propActiveBool != null) context.Entry(listDelete).Property(propActiveBool.Name).IsModified = true;

                            context.Set<T1>().Add(entitySave1);
                            context.Set<T2>().Add(entitySave2);
                            context.Set<T3>().Add(entitySave3);
                            context.Set<T4>().Add(entitySave4);

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, entitySave1, entitySave2, entitySave3, entitySave4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entitySave1 != null & entitySave2 != null & entitySave3 != null & entitySave4 != null & entitySave5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if(listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            entitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entitySave1);
                            entitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entitySave2);
                            entitySave3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entitySave3);
                            entitySave4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entitySave4);
                            entitySave5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(entitySave5);

                            listDelete = EntityPreparationBantuan.GetInstance.DictEntityPreparation["deleteactivebool"].SetPreparationEntity<TDelete>(listDelete);
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<TDelete>(MiscClass.MiscClass.ArrayActiveBool);
                            context.Set<TDelete>().AttachRange(listDelete);
                            context.Entry(listDelete).State = EntityState.Unchanged;
                            if (propUpdateDate != null) context.Entry(listDelete).Property(propUpdateDate.Name).IsModified = true;
                            if (propActiveBool != null) context.Entry(listDelete).Property(propActiveBool.Name).IsModified = true;

                            context.Set<T1>().Add(entitySave1);
                            context.Set<T2>().Add(entitySave2);
                            context.Set<T3>().Add(entitySave3);
                            context.Set<T4>().Add(entitySave4);
                            context.Set<T5>().Add(entitySave5);

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete,entitySave1,entitySave2,entitySave3,entitySave4,entitySave5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
    }
}
