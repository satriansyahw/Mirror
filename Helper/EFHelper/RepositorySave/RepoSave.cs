using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositorySave
{
    public  class RepoSave : InterfaceRepoSave
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false,ErrorMessage= ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        EntityMultiplePK multiple = new EntityMultiplePK();
        private static RepoSave instance;
        public static RepoSave GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSave();
                return instance;
            }
        }
        public virtual EFReturnValue Save<T>(T entity) where T : class
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
                            var cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T>(entity, out eFReturn);
                            if (cekIsContinue)
                            {

                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(entity);
                                context.Set<T>().Add(entity);
                                hasil = context.SaveChanges();
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity);
                            }
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }           
            return eFReturn;
        }          
        public virtual EFReturnValue Save<T1, T2>(T1 entity1, T2 entity2)
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
                        if(entity1 !=null & entity2 !=null)
                        {
                            var cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T1>(entity1, out eFReturn);
                            if(cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T2>(entity2, out eFReturn);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                context.Set<T1>().Add(entity1);
                                context.Set<T2>().Add(entity2);
                                hasil = context.SaveChanges();
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2);
                            }
                        }             
                      

                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue Save<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
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
                            var cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T1>(entity1, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T2>(entity2, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T3>(entity3, out eFReturn);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                                context.Set<T1>().Add(entity1);
                                context.Set<T2>().Add(entity2);
                                context.Set<T3>().Add(entity3);
                                hasil = context.SaveChanges();
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3);
                            }
                        }
                        
                       
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue Save<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
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
                            var cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T1>(entity1, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T2>(entity2, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T3>(entity3, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T4>(entity4, out eFReturn);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                                entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entity4);
                                context.Set<T1>().Add(entity1);
                                context.Set<T2>().Add(entity2);
                                context.Set<T3>().Add(entity3);
                                context.Set<T4>().Add(entity4);
                                hasil = context.SaveChanges();
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4);
                            }
                        }
                        
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue Save<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
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
                            var cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T1>(entity1, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T2>(entity2, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T3>(entity3, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T4>(entity4, out eFReturn);
                            if (cekIsContinue)
                                cekIsContinue = multiple.IsContinueSaveAfterMultiplePK<T5>(entity5, out eFReturn);
                            if (cekIsContinue)
                            {
                                entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                                entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                                entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                                entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entity4);
                                entity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(entity5);
                                context.Set<T1>().Add(entity1);
                                context.Set<T2>().Add(entity2);
                                context.Set<T3>().Add(entity3);
                                context.Set<T4>().Add(entity4);
                                context.Set<T5>().Add(entity5);
                                hasil = context.SaveChanges();
                                contextTrans.Commit();
                                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4, entity5);
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


