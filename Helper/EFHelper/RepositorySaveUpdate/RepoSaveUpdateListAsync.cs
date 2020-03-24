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
    public class RepoSaveUpdateListAsync:InterfaceRepoSaveUpdateListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoSaveUpdateListAsync instance;
        public static RepoSaveUpdateListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSaveUpdateListAsync();
                return instance;
            }
        }
        public async Task<EFReturnValue> SaveUpdateListAsync<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, isSaveT1);

                            if (isSaveT1) { await context.Set<T1>().AddRangeAsync(listEntity1); }

                            if (!isSaveT1)
                            {
                                for (int i = 0; i < listEntity1.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(listEntity1[i]);
                                    context.Set<T1>().Attach(listEntity1[i]);
                                    context.Entry(listEntity1[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT1)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity1[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, isSaveT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, isSaveT2);

                            if (isSaveT1) { await context.Set<T1>().AddRangeAsync(listEntity1); }
                            if (isSaveT2) { await context.Set<T2>().AddRangeAsync(listEntity2); }

                            if (!isSaveT1)
                            {
                                for (int i = 0; i < listEntity1.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(listEntity1[i]);
                                    context.Set<T1>().Attach(listEntity1[i]);
                                    context.Entry(listEntity1[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT1)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity1[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT2)
                            {
                                for (int i = 0; i < listEntity2.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(listEntity2[i]);
                                    context.Set<T2>().Attach(listEntity2[i]);
                                    context.Entry(listEntity2[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT2)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity2[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, isSaveT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, isSaveT2);
                            listEntity3 = this.SetEntityPreparation<T3>(listEntity3, isSaveT3);

                            if (isSaveT1) { await context.Set<T1>().AddRangeAsync(listEntity1); }
                            if (isSaveT2) { await context.Set<T2>().AddRangeAsync(listEntity2); }
                            if (isSaveT3) { await context.Set<T3>().AddRangeAsync(listEntity3); }



                            if (!isSaveT1)
                            {
                                for (int i = 0; i < listEntity1.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(listEntity1[i]);
                                    context.Set<T1>().Attach(listEntity1[i]);
                                    context.Entry(listEntity1[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT1)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity1[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT2)
                            {
                                for (int i = 0; i < listEntity2.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(listEntity2[i]);
                                    context.Set<T2>().Attach(listEntity2[i]);
                                    context.Entry(listEntity2[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT2)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity2[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT3)
                            {
                                for (int i = 0; i < listEntity3.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(listEntity3[i]);
                                    context.Set<T3>().Attach(listEntity3[i]);
                                    context.Entry(listEntity3[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT3)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity3[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, isSaveT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, isSaveT2);
                            listEntity3 = this.SetEntityPreparation<T3>(listEntity3, isSaveT3);
                            listEntity4 = this.SetEntityPreparation<T4>(listEntity4, isSaveT4);


                            if (isSaveT1) { await context.Set<T1>().AddRangeAsync(listEntity1); }
                            if (isSaveT2) { await context.Set<T2>().AddRangeAsync(listEntity2); }
                            if (isSaveT3) { await context.Set<T3>().AddRangeAsync(listEntity3); }
                            if (isSaveT4) { await context.Set<T4>().AddRangeAsync(listEntity4); }


                            if (!isSaveT1)
                            {
                                for (int i = 0; i < listEntity1.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(listEntity1[i]);
                                    context.Set<T1>().Attach(listEntity1[i]);
                                    context.Entry(listEntity1[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT1)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity1[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT2)
                            {
                                for (int i = 0; i < listEntity2.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(listEntity2[i]);
                                    context.Set<T2>().Attach(listEntity2[i]);
                                    context.Entry(listEntity2[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT2)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity2[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT3)
                            {
                                for (int i = 0; i < listEntity3.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(listEntity3[i]);
                                    context.Set<T3>().Attach(listEntity3[i]);
                                    context.Entry(listEntity3[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT3)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity3[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT4)
                            {
                                for (int i = 0; i < listEntity4.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(listEntity4[i]);
                                    context.Set<T4>().Attach(listEntity4[i]);
                                    context.Entry(listEntity4[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT4)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity4[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }

                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4.Count > 0 & listEntity5.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, isSaveT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, isSaveT2);
                            listEntity3 = this.SetEntityPreparation<T3>(listEntity3, isSaveT3);
                            listEntity4 = this.SetEntityPreparation<T4>(listEntity4, isSaveT4);
                            listEntity5 = this.SetEntityPreparation<T5>(listEntity5, isSaveT5);

                            if (isSaveT1) { await context.Set<T1>().AddRangeAsync(listEntity1); }
                            if (isSaveT2) { await context.Set<T2>().AddRangeAsync(listEntity2); }
                            if (isSaveT3) { await context.Set<T3>().AddRangeAsync(listEntity3); }
                            if (isSaveT4) { await context.Set<T4>().AddRangeAsync(listEntity4); }
                            if (isSaveT5) { await context.Set<T5>().AddRangeAsync(listEntity5); }



                            if (!isSaveT1)
                            {
                                for (int i = 0; i < listEntity1.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(listEntity1[i]);
                                    context.Set<T1>().Attach(listEntity1[i]);
                                    context.Entry(listEntity1[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT1)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity1[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT2)
                            {
                                for (int i = 0; i < listEntity2.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(listEntity2[i]);
                                    context.Set<T2>().Attach(listEntity2[i]);
                                    context.Entry(listEntity2[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT2)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity2[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT3)
                            {
                                for (int i = 0; i < listEntity3.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(listEntity3[i]);
                                    context.Set<T3>().Attach(listEntity3[i]);
                                    context.Entry(listEntity3[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT3)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity3[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT4)
                            {
                                for (int i = 0; i < listEntity4.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(listEntity4[i]);
                                    context.Set<T4>().Attach(listEntity4[i]);
                                    context.Entry(listEntity4[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT4)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity4[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }
                            if (!isSaveT5)
                            {
                                for (int i = 0; i < listEntity5.Count; i++)
                                {
                                    List<PropertyInfo> colNotNullT5 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T5>(listEntity5[i]);
                                    context.Set<T5>().Attach(listEntity5[i]);
                                    context.Entry(listEntity5[i]).State = EntityState.Unchanged;
                                    foreach (PropertyInfo property in colNotNullT5)
                                    {
                                        if (property != null)
                                        {
                                            context.Entry(listEntity5[i]).Property(property.Name).IsModified = true;
                                        }
                                    }
                                }

                            }


                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        private List<T> SetEntityPreparation<T>(List<T> listEntity, bool isSave) where T : class
        {
            if (isSave)
                listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(listEntity);
            else
                listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(listEntity);
            return listEntity;
        }

    }
}
