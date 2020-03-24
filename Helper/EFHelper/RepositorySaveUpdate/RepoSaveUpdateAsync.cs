using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositorySaveUpdate
{
    public class RepoSaveUpdateAsync:InterfaceRepoSaveUpdateAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoSaveUpdateAsync instance;
        public static RepoSaveUpdateAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSaveUpdateAsync();
                return instance;
            }
        }
        public async Task<EFReturnValue> SaveUpdateAsync<T1>(T1 entity1, bool isSaveT1) where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            entity1 = this.SetEntityPreparation<T1>(entity1, isSaveT1);
                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);

                            if (isSaveT1) await context.Set<T1>().AddAsync(entity1);

                            if (!isSaveT1)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            entity1 = this.SetEntityPreparation<T1>(entity1, isSaveT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, isSaveT2);

                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);

                            if (isSaveT1) await context.Set<T1>().AddAsync(entity1);
                            if (isSaveT2) await context.Set<T2>().AddAsync(entity2);
                            if (!isSaveT1)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT2)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null & entity3 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            entity1 = this.SetEntityPreparation<T1>(entity1, isSaveT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, isSaveT2);
                            entity3 = this.SetEntityPreparation<T3>(entity3, isSaveT3);

                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);
                            List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);

                            if (isSaveT1) await context.Set<T1>().AddAsync(entity1);
                            if (isSaveT2) await context.Set<T2>().AddAsync(entity2);
                            if (isSaveT3) await context.Set<T3>().AddAsync(entity3);

                            if (!isSaveT1)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT2)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT3)
                            {
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT3)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity3).Property(property.Name).IsModified = true;
                                    }
                                }
                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null & entity3 != null & entity4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            entity1 = this.SetEntityPreparation<T1>(entity1, isSaveT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, isSaveT2);
                            entity3 = this.SetEntityPreparation<T3>(entity3, isSaveT3);
                            entity4 = this.SetEntityPreparation<T4>(entity4, isSaveT4);

                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);
                            List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);
                            List<PropertyInfo> colNotNullT4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity4);
                            if (isSaveT1) await context.Set<T1>().AddAsync(entity1);
                            if (isSaveT2) await context.Set<T2>().AddAsync(entity2);
                            if (isSaveT3) await context.Set<T3>().AddAsync(entity3);
                            if (isSaveT4) await context.Set<T4>().AddAsync(entity4);

                            if (!isSaveT1)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT2)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT3)
                            {
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT3)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity3).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT4)
                            {
                                context.Set<T4>().Attach(entity4);
                                context.Entry(entity4).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT4)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity4).Property(property.Name).IsModified = true;
                                    }
                                }
                            }


                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null & entity3 != null & entity4 != null & entity5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {                            

                            entity1 = this.SetEntityPreparation<T1>(entity1, isSaveT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, isSaveT2);
                            entity3 = this.SetEntityPreparation<T3>(entity3, isSaveT3);
                            entity4 = this.SetEntityPreparation<T4>(entity4, isSaveT4);
                            entity5 = this.SetEntityPreparation<T5>(entity5, isSaveT5);

                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);
                            List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);
                            List<PropertyInfo> colNotNullT4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity4);
                            List<PropertyInfo> colNotNullT5 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T5>(entity5);

                            if (isSaveT1) await context.Set<T1>().AddAsync(entity1);
                            if (isSaveT2) await context.Set<T2>().AddAsync(entity2);
                            if (isSaveT3) await context.Set<T3>().AddAsync(entity3);
                            if (isSaveT4) await context.Set<T4>().AddAsync(entity4);
                            if (isSaveT5) await context.Set<T5>().AddAsync(entity5);

                            if (!isSaveT1)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT2)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT3)
                            {
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT3)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity3).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT4)
                            {
                                context.Set<T4>().Attach(entity4);
                                context.Entry(entity4).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT4)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity4).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (!isSaveT5)
                            {
                                context.Set<T5>().Attach(entity5);
                                context.Entry(entity5).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT5)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity5).Property(property.Name).IsModified = true;
                                    }
                                }
                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4, entity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }

        private T SetEntityPreparation<T>(T entity, bool isSave) where T : class
        {
            if (isSave)
                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(entity);
            else
                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(entity);
            return entity;
        }
    }
}
