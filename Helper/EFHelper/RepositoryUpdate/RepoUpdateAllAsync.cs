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

namespace EFHelper.RepositoryUpdate
{
    public class RepoUpdateAllAsync : InterfaceRepoUpdateAllAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoUpdateAllAsync instance;
        EntityMultiplePK multiple = new EntityMultiplePK();
        private string multipleErrorMessage = "Error, Violation of Multiple PK, check : ";
        public static RepoUpdateAllAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoUpdateAllAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> UpdateAllAsync<T>(T entity) where T : class
        { 
            if (entity != null)
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
                                var cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T>(entity).ConfigureAwait(false);
                                if (cekIsContinue)
                                {
                                    entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(entity);
                                    context.Set<T>().Attach(entity);
                                    context.Entry(entity).State = EntityState.Modified;

                                                                hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                    contextTrans.Commit();
                                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity);
                                }
                                else
                                {
                                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                                }
                            }
                            catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                        }
                    }
                }
                return eFReturn;
            }
            return eFReturn; 
        }
        public virtual async Task<EFReturnValue> UpdateAllAsync<T1, T2>(T1 entity1, T2 entity2)
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
                            var cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T1>(entity1).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T2>(entity2).ConfigureAwait(false);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);

                                context.Set<T1>().Attach(entity1);
                                context.Set<T2>().Attach(entity2);

                                context.Entry(entity1).State = EntityState.Modified;
                                context.Entry(entity2).State = EntityState.Modified;

                                hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                            }
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
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
                            var cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T1>(entity1).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T2>(entity2).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T3>(entity3).ConfigureAwait(false);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity3);

                                context.Set<T1>().Attach(entity1);
                                context.Set<T2>().Attach(entity2);
                                context.Set<T3>().Attach(entity3);

                                context.Entry(entity1).State = EntityState.Modified;
                                context.Entry(entity2).State = EntityState.Modified;
                                context.Entry(entity3).State = EntityState.Modified;

                                                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                            }
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
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
                            var cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T1>(entity1).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T2>(entity2).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T3>(entity3).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T4>(entity4).ConfigureAwait(false);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity3);
                                entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity4);

                                context.Set<T1>().Attach(entity1);
                                context.Set<T2>().Attach(entity2);
                                context.Set<T3>().Attach(entity3);
                                context.Set<T4>().Attach(entity4);

                                context.Entry(entity1).State = EntityState.Modified;
                                context.Entry(entity2).State = EntityState.Modified;
                                context.Entry(entity3).State = EntityState.Modified;
                                context.Entry(entity4).State = EntityState.Modified;

                                                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                            }
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
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
                            var cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T1>(entity1).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T2>(entity2).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T3>(entity3).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T4>(entity4).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueUpdateAfterMultiplePKAsync<T5>(entity5).ConfigureAwait(false);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity3);
                                entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity4);
                                entity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T5>(entity5);

                                context.Set<T1>().Attach(entity1);
                                context.Set<T2>().Attach(entity2);
                                context.Set<T3>().Attach(entity3);
                                context.Set<T4>().Attach(entity4);
                                context.Set<T5>().Attach(entity5);

                                context.Entry(entity1).State = EntityState.Modified;
                                context.Entry(entity2).State = EntityState.Modified;
                                context.Entry(entity3).State = EntityState.Modified;
                                context.Entry(entity4).State = EntityState.Modified;
                                context.Entry(entity5).State = EntityState.Modified;

                                                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4, entity5);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                            }
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
    }
}
