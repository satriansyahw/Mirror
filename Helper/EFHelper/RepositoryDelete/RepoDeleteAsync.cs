using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteAsync : InterfaceRepoDeleteAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteAsync instance;
        public static RepoDeleteAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> DeleteAsync<T>(int IDIdentity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity > 0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity1 > 0 & IDIdentity2 > 0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T1 entity1 = Activator.CreateInstance<T1>();
                            T2 entity2 = Activator.CreateInstance<T2>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);



                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);

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
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity1 > 0 & IDIdentity2 > 0 & IDIdentity3 > 0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T1 entity1 = Activator.CreateInstance<T1>();
                            T2 entity2 = Activator.CreateInstance<T2>();
                            T3 entity3 = Activator.CreateInstance<T3>();

                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T3>(entity3, IDIdentity3);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);
                            context.Set<T3>().Remove(entity3);

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
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity1 > 0 & IDIdentity2 > 0 & IDIdentity3 > 0 & IDIdentity4 > 0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T1 entity1 = Activator.CreateInstance<T1>();
                            T2 entity2 = Activator.CreateInstance<T2>();
                            T3 entity3 = Activator.CreateInstance<T3>();
                            T4 entity4 = Activator.CreateInstance<T4>();

                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T3>(entity3, IDIdentity3);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T4>(entity4, IDIdentity4);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);
                            context.Set<T3>().Remove(entity3);
                            context.Set<T4>().Remove(entity4);

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
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity1 > 0 & IDIdentity2 > 0 & IDIdentity3 > 0 & IDIdentity4 > 0 & IDIdentity5 > 0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T1 entity1 = Activator.CreateInstance<T1>();
                            T2 entity2 = Activator.CreateInstance<T2>();
                            T3 entity3 = Activator.CreateInstance<T3>();
                            T4 entity4 = Activator.CreateInstance<T4>();
                            T5 entity5 = Activator.CreateInstance<T5>();

                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T3>(entity3, IDIdentity3);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T4>(entity4, IDIdentity4);
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T5>(entity5, IDIdentity5);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);
                            context.Set<T5>().Attach(entity5);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);
                            context.Set<T3>().Remove(entity3);
                            context.Set<T4>().Remove(entity4);
                            context.Set<T5>().Remove(entity5);

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
        public virtual async Task<EFReturnValue> DeleteAsync<T>(T entity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2>(T1 entity1, T2 entity2)
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
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);

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
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
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
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);
                            context.Set<T3>().Remove(entity3);

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
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
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
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);
                            context.Set<T3>().Remove(entity3);
                            context.Set<T4>().Remove(entity4);

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
        public virtual async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
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
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);
                            context.Set<T5>().Attach(entity5);

                            context.Set<T1>().Remove(entity1);
                            context.Set<T2>().Remove(entity2);
                            context.Set<T3>().Remove(entity3);
                            context.Set<T4>().Remove(entity4);
                            context.Set<T5>().Remove(entity5);

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
    }
}
