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
    public class RepoUpdateAllListAsync : InterfaceRepoUpdateAllListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoUpdateAllListAsync instance;
        public static RepoUpdateAllListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoUpdateAllListAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> UpdateAllListAsync<T>(List<T> listEntity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(listEntity);

                            foreach (var item in listEntity) { context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Modified; }


                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn; 
        }
        public virtual async Task<EFReturnValue> UpdateAllListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 !=null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Modified; }


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
        public virtual async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
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
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(listEntity3);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Modified; }


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
        public virtual async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
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
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(listEntity4);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Modified; }


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
        public virtual async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
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
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T5>(listEntity5);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Modified; }
                            foreach (var item in listEntity5) { context.Set<T5>().Attach(item); context.Entry(item).State = EntityState.Modified; }


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


    }
}
