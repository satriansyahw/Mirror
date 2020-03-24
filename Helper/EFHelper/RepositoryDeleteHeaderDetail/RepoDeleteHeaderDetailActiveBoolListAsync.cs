using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using EFHelper.TypeHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetailActiveBoolListAsync : InterfaceRepoDeleteHeaderDetailActiveBoolListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteHeaderDetailActiveBoolListAsync instance;
        public static RepoDeleteHeaderDetailActiveBoolListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteHeaderDetailActiveBoolListAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);
                            List<T1> listEntity1 =await this.GetListData<T1>(listIDIdentity, idReferenceColName);

                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);

                            foreach (var item in listEntity)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }


                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);
                            List<T1> listEntity1 =await this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 =await this.GetListData<T2>(listIDIdentity, idReferenceColName);

                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);

                            foreach (var item in listEntity)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);
                            List<T1> listEntity1 =await this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 =await this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 =await this.GetListData<T3>(listIDIdentity, idReferenceColName);

                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);

                            foreach (var item in listEntity)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);
                            List<T1> listEntity1 =await this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 =await this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 =await this.GetListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 =await this.GetListData<T4>(listIDIdentity, idReferenceColName);

                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);

                            foreach (var item in listEntity)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity4)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);
                            List<T1> listEntity1 =await this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 =await this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 =await this.GetListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 =await this.GetListData<T4>(listIDIdentity, idReferenceColName);
                            List<T5> listEntity5 =await this.GetListData<T5>(listIDIdentity, idReferenceColName);

                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(listEntity5);

                            foreach (var item in listEntity)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity4)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }
                            foreach (var item in listEntity5)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T5>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }

        private async Task<List<T>> GetListData<T>(List<int> listIDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>
            {
                new SearchField { Name = idReferenceColName, Operator = "=", Value = listIDIdentity }
            };
            RepoListAsync list = new RepoListAsync();
            var myList = await list.ListDataAsync<T>(param);
            var myListData = (List<T>)myList.ReturnValue[0].ReturnValue;
            return (myList.IsSuccessConnection & myList.IsSuccessQuery & myListData.Count > 0) ? myListData : null;
        }
    }
}
