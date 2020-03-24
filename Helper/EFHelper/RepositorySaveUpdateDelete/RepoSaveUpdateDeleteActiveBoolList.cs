using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static EFHelper.MiscClass.MiscClass;

namespace EFHelper.RepositorySaveUpdateDelete
{
    public class RepoSaveUpdateDeleteActiveBoolList : InterfaceRepoSaveUpdateDeleteActiveBoolList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoSaveUpdateDeleteActiveBoolList instance;
        public static RepoSaveUpdateDeleteActiveBoolList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSaveUpdateDeleteActiveBoolList();
                return instance;
            }
        }        

        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1) where T1 : class
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
                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, enumSUDT1);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) context.Set<T1>().AddRange(listEntity1);


                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity1)
                                {
                                    context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }

                            }


                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
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

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2)
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
                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, enumSUDT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, enumSUDT2);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) context.Set<T1>().AddRange(listEntity1);
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) context.Set<T2>().AddRange(listEntity2);


                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity1)
                                {
                                    context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }

                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity2)
                                {
                                    context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }

                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
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
        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3)
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
                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, enumSUDT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, enumSUDT2);
                            listEntity3 = this.SetEntityPreparation<T3>(listEntity3, enumSUDT3);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) context.Set<T1>().AddRange(listEntity1);
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) context.Set<T2>().AddRange(listEntity2);
                            if (enumSUDT3 == EnumSaveUpdateDelete.Save) context.Set<T3>().AddRange(listEntity3);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity1)
                                {
                                    context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }

                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity2)
                                {
                                    context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity3)
                                {
                                    context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }

                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT3 == EnumSaveUpdateDelete.Update)
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
        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, enumSUDT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, enumSUDT2);
                            listEntity3 = this.SetEntityPreparation<T3>(listEntity3, enumSUDT3);
                            listEntity4 = this.SetEntityPreparation<T4>(listEntity4, enumSUDT4);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) context.Set<T1>().AddRange(listEntity1);
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) context.Set<T2>().AddRange(listEntity2);
                            if (enumSUDT3 == EnumSaveUpdateDelete.Save) context.Set<T3>().AddRange(listEntity3);
                            if (enumSUDT4 == EnumSaveUpdateDelete.Save) context.Set<T4>().AddRange(listEntity4);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity1)
                                {
                                    context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }

                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity2)
                                {
                                    context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity3)
                                {
                                    context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }
                            if (enumSUDT4 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity4)
                                {
                                    context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }


                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT3 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT4 == EnumSaveUpdateDelete.Update)
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
        public EFReturnValue SaveUpdateDeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null & listEntity5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = this.SetEntityPreparation<T1>(listEntity1, enumSUDT1);
                            listEntity2 = this.SetEntityPreparation<T2>(listEntity2, enumSUDT2);
                            listEntity3 = this.SetEntityPreparation<T3>(listEntity3, enumSUDT3);
                            listEntity4 = this.SetEntityPreparation<T4>(listEntity4, enumSUDT4);
                            listEntity5 = this.SetEntityPreparation<T5>(listEntity5, enumSUDT5);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) context.Set<T1>().AddRange(listEntity1); 
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) context.Set<T2>().AddRange(listEntity2);
                            if (enumSUDT3 == EnumSaveUpdateDelete.Save) context.Set<T3>().AddRange(listEntity3);
                            if (enumSUDT4 == EnumSaveUpdateDelete.Save) context.Set<T4>().AddRange(listEntity4);
                            if (enumSUDT5 == EnumSaveUpdateDelete.Save) context.Set<T5>().AddRange(listEntity5);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity1)
                                {
                                    context.Set<T1>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                               
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity2)
                                {
                                    context.Set<T2>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity3)
                                {
                                    context.Set<T3>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }
                            if (enumSUDT4 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity4)
                                {
                                    context.Set<T4>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }
                            if (enumSUDT5 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);
                                foreach (var item in listEntity5)
                                {
                                    context.Set<T5>().Attach(item); context.Entry(item).State = EntityState.Unchanged;
                                    if (propUpdateDate != null) context.Entry(item).Property(propUpdateDate.Name).IsModified = true;
                                    if (propActiveBool != null) context.Entry(item).Property(propActiveBool.Name).IsModified = true;
                                }
                            }

                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT3 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT4 == EnumSaveUpdateDelete.Update)
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
                            if (enumSUDT5 == EnumSaveUpdateDelete.Update)
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

        private List<T> SetEntityPreparation<T>(List<T> listEntity, EnumSaveUpdateDelete saveUpdateDelete) where T : class
        {
            if (saveUpdateDelete == EnumSaveUpdateDelete.Save)
                listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(listEntity);
            else if (saveUpdateDelete == EnumSaveUpdateDelete.Update)
                listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(listEntity);
            else
                listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["deleteactivebool"].SetPreparationEntity<T>(listEntity);
            return listEntity;
        }
    }
}
