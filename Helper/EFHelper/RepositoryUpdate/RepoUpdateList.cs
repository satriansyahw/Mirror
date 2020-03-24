using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.RepositoryUpdate
{
    public class RepoUpdateList : InterfaceRepoUpdateList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoUpdateList instance;
        public static RepoUpdateList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoUpdateList();
                return instance;
            }
        }
        public virtual EFReturnValue UpdateList<T>(List<T> listEntity) where T : class
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
                            for (int i = 0; i < listEntity.Count; i++)
                            {
                                T entity = listEntity[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
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

        public virtual EFReturnValue UpdateList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
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

        public virtual EFReturnValue UpdateList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity3.Count; i++)
                            {
                                T3 entity = listEntity3[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T3>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
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

        public virtual EFReturnValue UpdateList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 & listEntity4.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity3.Count; i++)
                            {
                                T3 entity = listEntity3[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T3>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity4.Count; i++)
                            {
                                T4 entity = listEntity4[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T4>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
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

        public virtual EFReturnValue UpdateList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 & listEntity4.Count > 0 & listEntity5.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity3.Count; i++)
                            {
                                T3 entity = listEntity3[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T3>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity4.Count; i++)
                            {
                                T4 entity = listEntity4[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T4>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity5.Count; i++)
                            {
                                T5 entity = listEntity5[i];
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T5>(entity);
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T5>(entity);//will update except activebool boolactive insertby insertbyid
                                context.Set<T5>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
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
