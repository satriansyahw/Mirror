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
using System.Reflection;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteActiveBoolList : InterfaceRepoDeleteActiveBoolList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteActiveBoolList instance;
        public static RepoDeleteActiveBoolList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteActiveBoolList();
                return instance;
            }
        }
        public virtual EFReturnValue DeleteActiveBoolList<T>(List<int> listIDIdentity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity != null)
            {
               
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity = new List<T>();
                            listEntity = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);                           
                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);

                            foreach (var item in listEntity)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1 != null & listIDIdentity2 != null)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            

                            List<T1> listEntity1 = new List<T1>();
                            listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            List<T2> listEntity2 = new List<T2>();
                            listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1 != null & listIDIdentity2 != null & listIDIdentity3 != null )
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            

                            List<T1> listEntity1 = new List<T1>();
                            listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            List<T2> listEntity2 = new List<T2>();
                            listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            List<T3> listEntity3 = new List<T3>();
                            listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);

                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate3 != null) context.Entry(item).Property(propUpdateDate3.Name).IsModified = true;
                                if (propActiveBool3 != null) context.Entry(item).Property(propActiveBool3.Name).IsModified = true;
                            }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1 != null & listIDIdentity2 != null & listIDIdentity3 != null & listIDIdentity4 != null)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {                            

                            List<T1> listEntity1 = new List<T1>();
                            listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            List<T2> listEntity2 = new List<T2>();
                            listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            List<T3> listEntity3 = new List<T3>();
                            listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            List<T4> listEntity4 = new List<T4>();
                            listEntity4 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T4>(listIDIdentity4);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);

                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate3 != null) context.Entry(item).Property(propUpdateDate3.Name).IsModified = true;
                                if (propActiveBool3 != null) context.Entry(item).Property(propActiveBool3.Name).IsModified = true;
                            }
                            foreach (var item in listEntity4)
                            {
                                var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate4 != null) context.Entry(item).Property(propUpdateDate4.Name).IsModified = true;
                                if (propActiveBool4 != null) context.Entry(item).Property(propActiveBool4.Name).IsModified = true;
                            }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1 != null & listIDIdentity2 != null & listIDIdentity3 != null & listIDIdentity4 != null & listIDIdentity5 != null)
            {

                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            

                            List<T1> listEntity1 = new List<T1>();
                            listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            List<T2> listEntity2 = new List<T2>();
                            listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            List<T3> listEntity3 = new List<T3>();
                            listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            List<T4> listEntity4 = new List<T4>();
                            listEntity4 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T4>(listIDIdentity4);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);
                            List<T5> listEntity5 = new List<T5>();
                            listEntity5 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T5>(listIDIdentity5);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(listEntity5);

                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate3 != null) context.Entry(item).Property(propUpdateDate3.Name).IsModified = true;
                                if (propActiveBool3 != null) context.Entry(item).Property(propActiveBool3.Name).IsModified = true;
                            }
                            foreach (var item in listEntity4)
                            {
                                var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate4 != null) context.Entry(item).Property(propUpdateDate4.Name).IsModified = true;
                                if (propActiveBool4 != null) context.Entry(item).Property(propActiveBool4.Name).IsModified = true;
                            }
                            foreach (var item in listEntity5)
                            {
                                var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T5>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate5 != null) context.Entry(item).Property(propUpdateDate5.Name).IsModified = true;
                                if (propActiveBool5 != null) context.Entry(item).Property(propActiveBool5.Name).IsModified = true;
                            }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T>(List<T> listEntity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);

                            foreach (var item in listEntity)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }                           

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);

                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate3 != null) context.Entry(item).Property(propUpdateDate3.Name).IsModified = true;
                                if (propActiveBool3 != null) context.Entry(item).Property(propActiveBool3.Name).IsModified = true;
                            }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);

                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate3 != null) context.Entry(item).Property(propUpdateDate3.Name).IsModified = true;
                                if (propActiveBool3 != null) context.Entry(item).Property(propActiveBool3.Name).IsModified = true;
                            }
                            foreach (var item in listEntity4)
                            {
                                var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate4 != null) context.Entry(item).Property(propUpdateDate4.Name).IsModified = true;
                                if (propActiveBool4 != null) context.Entry(item).Property(propActiveBool4.Name).IsModified = true;
                            }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null }; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null & listEntity5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(listEntity5);          
                         

                            foreach (var item in listEntity1)
                            {
                                var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate1 != null) context.Entry(item).Property(propUpdateDate1.Name).IsModified = true;
                                if (propActiveBool1 != null) context.Entry(item).Property(propActiveBool1.Name).IsModified = true;
                            }
                            foreach (var item in listEntity2)
                            {
                                var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate2 != null) context.Entry(item).Property(propUpdateDate2.Name).IsModified = true;
                                if (propActiveBool2 != null) context.Entry(item).Property(propActiveBool2.Name).IsModified = true;
                            }
                            foreach (var item in listEntity3)
                            {
                                var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate3 != null) context.Entry(item).Property(propUpdateDate3.Name).IsModified = true;
                                if (propActiveBool3 != null) context.Entry(item).Property(propActiveBool3.Name).IsModified = true;
                            }
                            foreach (var item in listEntity4)
                            {
                                var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate4 != null) context.Entry(item).Property(propUpdateDate4.Name).IsModified = true;
                                if (propActiveBool4 != null) context.Entry(item).Property(propActiveBool4.Name).IsModified = true;
                            }
                            foreach (var item in listEntity5)
                            {
                                var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T5>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                if (propUpdateDate5 != null) context.Entry(item).Property(propUpdateDate5.Name).IsModified = true;
                                if (propActiveBool5 != null) context.Entry(item).Property(propActiveBool5.Name).IsModified = true;
                            }

                            hasil = context.SaveChanges();
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
