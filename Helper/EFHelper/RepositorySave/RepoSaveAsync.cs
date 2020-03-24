using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositorySave
{
    public  class RepoSaveAsync : InterfaceRepoSaveAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull,ReturnValue=null };
        private static RepoSaveAsync instance;
        EntityMultiplePK multiple = new EntityMultiplePK();
        private string multipleErrorMessage = "Error, Violation of Multiple PK, check : ";
        public static RepoSaveAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSaveAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> SaveAsync<T>(T entity) where T : class
        {
            var entityResult = Activator.CreateInstance<T>();
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

            if (entity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T>(entity);
                            if (cekIsContinue)
                            {
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(entity);
                                await context.Set<T>().AddAsync(entity);
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
        public virtual async Task<EFReturnValue> SaveAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null)
                        {
                            var cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T1>(entity1).ConfigureAwait(false);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T2>(entity2).ConfigureAwait(false);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                await context.Set<T1>().AddAsync(entity1);
                                await context.Set<T2>().AddAsync(entity2);
                                hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                            }

                        }
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null & entity3 != null)
                        {
                            var cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T1>(entity1);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T2>(entity2);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T3>(entity3);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                                await context.Set<T1>().AddAsync(entity1);
                                await context.Set<T2>().AddAsync(entity2);
                                await context.Set<T3>().AddAsync(entity3);
                                hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                            }

                        }

                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null & entity3 != null & entity4 != null)
                        {
                            var cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T1>(entity1);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T2>(entity2);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T3>(entity3);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T4>(entity4);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                                entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entity4);
                                await context.Set<T1>().AddAsync(entity1);
                                await context.Set<T2>().AddAsync(entity2);
                                await context.Set<T3>().AddAsync(entity3);
                                await context.Set<T4>().AddAsync(entity4);
                                hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);

                            }

                        }
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null & entity3 != null & entity4 != null & entity5 != null)
                        {
                            var cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T1>(entity1);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T2>(entity2);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T3>(entity3);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T4>(entity4);
                            if (cekIsContinue)
                                cekIsContinue = await multiple.IsContinueSaveAfterMultiplePKAsync<T5>(entity5);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                                entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entity4);
                                entity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(entity5);
                                await context.Set<T1>().AddAsync(entity1);
                                await context.Set<T2>().AddAsync(entity2);
                                await context.Set<T3>().AddAsync(entity3);
                                await context.Set<T4>().AddAsync(entity4);
                                await context.Set<T5>().AddAsync(entity5);

                                                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4, entity5);
                            }
                            else
                            {
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, this.multipleErrorMessage);
                               
                            }
                        }                        
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                }
            }
            return eFReturn;
        }
    }
}
