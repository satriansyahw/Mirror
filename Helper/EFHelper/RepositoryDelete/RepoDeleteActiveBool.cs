using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using EFHelper.TypeHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteActiveBool : InterfaceRepoDeleteActiveBool
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteActiveBool instance;
        public static RepoDeleteActiveBool GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteActiveBool();
                return instance;
            }
        }
        public virtual EFReturnValue DeleteActiveBool<T>(int IDIdentity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            
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
                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);                            
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                            
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            if (propUpdateDate != null) context.Entry(entity).Property(propUpdateDate.Name).IsModified = true;
                            if (propActiveBool != null) context.Entry(entity).Property(propActiveBool.Name).IsModified = true;
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

            if (IDIdentity1 > 0 & IDIdentity2 > 0 )
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            

                            T1 entity1 = Activator.CreateInstance<T1>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);

                            T2 entity2 = Activator.CreateInstance<T2>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2); 

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);

                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

            if (IDIdentity1 > 0 & IDIdentity2 > 0 & IDIdentity3 > 0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {                   

                            T1 entity1 = Activator.CreateInstance<T1>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);

                            T2 entity2 = Activator.CreateInstance<T2>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2);

                            T3 entity3 = Activator.CreateInstance<T3>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T3>(entity3, IDIdentity3);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(entity3);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;
                            context.Entry(entity3).State = EntityState.Unchanged;

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);

                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;
                            if (propUpdateDate3 != null) context.Entry(entity3).Property(propUpdateDate3.Name).IsModified = true;
                            if (propActiveBool3 != null) context.Entry(entity3).Property(propActiveBool3.Name).IsModified = true;

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

            if (IDIdentity1 > 0 & IDIdentity2 > 0 & IDIdentity3 > 0 & IDIdentity4 >0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T1 entity1 = Activator.CreateInstance<T1>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);

                            T2 entity2 = Activator.CreateInstance<T2>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2);

                            T3 entity3 = Activator.CreateInstance<T3>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T3>(entity3, IDIdentity3);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(entity3);

                            T4 entity4 = Activator.CreateInstance<T4>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T4>(entity4, IDIdentity4);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(entity4);


                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;
                            context.Entry(entity3).State = EntityState.Unchanged;
                            context.Entry(entity4).State = EntityState.Unchanged;

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);

                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;
                            if (propUpdateDate3 != null) context.Entry(entity3).Property(propUpdateDate3.Name).IsModified = true;
                            if (propActiveBool3 != null) context.Entry(entity3).Property(propActiveBool3.Name).IsModified = true;
                            if (propUpdateDate4 != null) context.Entry(entity4).Property(propUpdateDate4.Name).IsModified = true;
                            if (propActiveBool4 != null) context.Entry(entity4).Property(propActiveBool4.Name).IsModified = true;

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
          
            if (IDIdentity1 > 0  & IDIdentity2 > 0 & IDIdentity3 > 0 & IDIdentity4 > 0 & IDIdentity5 > 0)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            

                            T1 entity1 = Activator.CreateInstance<T1>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T1>(entity1, IDIdentity1);
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);

                            T2 entity2= Activator.CreateInstance<T2>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T2>(entity2, IDIdentity2);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2);

                            T3 entity3 = Activator.CreateInstance<T3>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T3>(entity3, IDIdentity3);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(entity3);

                            T4 entity4 = Activator.CreateInstance<T4>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T4>(entity4, IDIdentity4);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(entity4);

                            T5 entity5 = Activator.CreateInstance<T5>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T5>(entity5, IDIdentity5);
                            entity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(entity5);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);
                            context.Set<T5>().Attach(entity5);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;
                            context.Entry(entity3).State = EntityState.Unchanged;
                            context.Entry(entity4).State = EntityState.Unchanged;
                            context.Entry(entity5).State = EntityState.Unchanged;

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);

                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;
                            if (propUpdateDate3 != null) context.Entry(entity3).Property(propUpdateDate3.Name).IsModified = true;
                            if (propActiveBool3 != null) context.Entry(entity3).Property(propActiveBool3.Name).IsModified = true;
                            if (propUpdateDate4 != null) context.Entry(entity4).Property(propUpdateDate4.Name).IsModified = true;
                            if (propActiveBool4 != null) context.Entry(entity4).Property(propActiveBool4.Name).IsModified = true;
                            if (propUpdateDate5 != null) context.Entry(entity5).Property(propUpdateDate5.Name).IsModified = true;
                            if (propActiveBool5 != null) context.Entry(entity5).Property(propActiveBool5.Name).IsModified = true;


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4, entity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T>(T entity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;

                            if (propUpdateDate != null) context.Entry(entity).Property(propUpdateDate.Name).IsModified = true;
                            if (propActiveBool != null) context.Entry(entity).Property(propActiveBool.Name).IsModified = true;


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;

                            context.Entry(entity2).State = EntityState.Unchanged;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null & entity3 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(entity3);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;

                            context.Entry(entity2).State = EntityState.Unchanged;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;

                            context.Entry(entity3).State = EntityState.Unchanged;
                            if (propUpdateDate3 != null) context.Entry(entity3).Property(propUpdateDate3.Name).IsModified = true;
                            if (propActiveBool3 != null) context.Entry(entity3).Property(propActiveBool3.Name).IsModified = true;

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null & entity3 != null & entity4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(entity3);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(entity4);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;

                            context.Entry(entity2).State = EntityState.Unchanged;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;

                            context.Entry(entity3).State = EntityState.Unchanged;
                            if (propUpdateDate3 != null) context.Entry(entity3).Property(propUpdateDate3.Name).IsModified = true;
                            if (propActiveBool3 != null) context.Entry(entity3).Property(propActiveBool3.Name).IsModified = true;

                            context.Entry(entity4).State = EntityState.Unchanged;
                            if (propUpdateDate4 != null) context.Entry(entity4).Property(propUpdateDate4.Name).IsModified = true;
                            if (propActiveBool4 != null) context.Entry(entity4).Property(propActiveBool4.Name).IsModified = true;

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1, entity2, entity3, entity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null & entity2 != null & entity3 != null & entity4 != null & entity5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(entity3);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(entity4);
                            entity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(entity5);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);
                            context.Set<T5>().Attach(entity5);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            if (propUpdateDate1 != null) context.Entry(entity1).Property(propUpdateDate1.Name).IsModified = true;
                            if (propActiveBool1 != null) context.Entry(entity1).Property(propActiveBool1.Name).IsModified = true;

                            context.Entry(entity2).State = EntityState.Unchanged;
                            if (propUpdateDate2 != null) context.Entry(entity2).Property(propUpdateDate2.Name).IsModified = true;
                            if (propActiveBool2 != null) context.Entry(entity2).Property(propActiveBool2.Name).IsModified = true;

                            context.Entry(entity3).State = EntityState.Unchanged;
                            if (propUpdateDate3 != null) context.Entry(entity3).Property(propUpdateDate3.Name).IsModified = true;
                            if (propActiveBool3 != null) context.Entry(entity3).Property(propActiveBool3.Name).IsModified = true;

                            context.Entry(entity4).State = EntityState.Unchanged;
                            if (propUpdateDate4 != null) context.Entry(entity4).Property(propUpdateDate4.Name).IsModified = true;
                            if (propActiveBool4 != null) context.Entry(entity4).Property(propActiveBool4.Name).IsModified = true;

                            context.Entry(entity5).State = EntityState.Unchanged;
                            if (propUpdateDate5 != null) context.Entry(entity5).Property(propUpdateDate5.Name).IsModified = true;
                            if (propActiveBool5 != null) context.Entry(entity5).Property(propActiveBool5.Name).IsModified = true;

                            hasil = context.SaveChanges();
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
