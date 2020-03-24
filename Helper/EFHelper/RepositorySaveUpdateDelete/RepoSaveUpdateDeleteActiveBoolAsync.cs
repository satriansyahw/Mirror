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
using static EFHelper.MiscClass.MiscClass;

namespace EFHelper.RepositorySaveUpdateDelete
{
    public class RepoSaveUpdateDeleteActiveBoolAsync : InterfaceRepoSaveUpdateDeleteActiveBoolAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoSaveUpdateDeleteActiveBoolAsync instance;
        public static RepoSaveUpdateDeleteActiveBoolAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSaveUpdateDeleteActiveBoolAsync();
                return instance;
            }
        }

        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1>(T1 entity1, EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (entity1 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            entity1 = this.SetEntityPreparation<T1>(entity1, enumSUDT1);
                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) await context.Set<T1>().AddAsync(entity1);


                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity1).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity1).Property(propActiveBool.Name).IsModified = true;
                            }
                            
                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
 
                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2)
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

                            entity1 = this.SetEntityPreparation<T1>(entity1, enumSUDT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, enumSUDT2);
                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) await context.Set<T1>().AddAsync(entity1);
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) await context.Set<T2>().AddAsync(entity2);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity1).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity1).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity2).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity2).Property(propActiveBool.Name).IsModified = true;
                            }

                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
 
                                                        hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3)
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

                            entity1 = this.SetEntityPreparation<T1>(entity1, enumSUDT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, enumSUDT2);
                            entity3 = this.SetEntityPreparation<T3>(entity3, enumSUDT3);
                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);
                            List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) await context.Set<T1>().AddAsync(entity1);
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) await context.Set<T2>().AddAsync(entity2);
                            if (enumSUDT3 == EnumSaveUpdateDelete.Save) await context.Set<T3>().AddAsync(entity3);


                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity1).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity1).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity2).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity2).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity3).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity3).Property(propActiveBool.Name).IsModified = true;
                            }

                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT3)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity3).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
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
        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4)
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

                            entity1 = this.SetEntityPreparation<T1>(entity1, enumSUDT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, enumSUDT2);
                            entity3 = this.SetEntityPreparation<T3>(entity3, enumSUDT3);
                            entity4 = this.SetEntityPreparation<T4>(entity4, enumSUDT4);
                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);
                            List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);
                            List<PropertyInfo> colNotNullT4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity4);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) await context.Set<T1>().AddAsync(entity1);
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) await context.Set<T2>().AddAsync(entity2);
                            if (enumSUDT3 == EnumSaveUpdateDelete.Save) await context.Set<T3>().AddAsync(entity3);
                            if (enumSUDT4 == EnumSaveUpdateDelete.Save) await context.Set<T4>().AddAsync(entity4);


                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity1).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity1).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity2).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity2).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity3).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity3).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT4 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(entity4);
                                context.Entry(entity4).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity4).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity4).Property(propActiveBool.Name).IsModified = true;
                            }

                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT3)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity3).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT4 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T4>().Attach(entity4);
                                context.Entry(entity4).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT4)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity4).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
   
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
        public async Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, EnumSaveUpdateDelete enumSUDT1, T2 entity2, EnumSaveUpdateDelete enumSUDT2, T3 entity3, EnumSaveUpdateDelete enumSUDT3, T4 entity4, EnumSaveUpdateDelete enumSUDT4, T5 entity5, EnumSaveUpdateDelete enumSUDT5)
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
                            entity1 = this.SetEntityPreparation<T1>(entity1, enumSUDT1);
                            entity2 = this.SetEntityPreparation<T2>(entity2, enumSUDT2);
                            entity3 = this.SetEntityPreparation<T3>(entity3, enumSUDT3);
                            entity4 = this.SetEntityPreparation<T4>(entity4, enumSUDT4);
                            entity5 = this.SetEntityPreparation<T5>(entity5, enumSUDT5);

                            List<PropertyInfo> colNotNullT1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);
                            List<PropertyInfo> colNotNullT2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);
                            List<PropertyInfo> colNotNullT3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);
                            List<PropertyInfo> colNotNullT4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity4);
                            List<PropertyInfo> colNotNullT5 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T5>(entity5);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Save) await context.Set<T1>().AddAsync(entity1);
                            if (enumSUDT2 == EnumSaveUpdateDelete.Save) await context.Set<T2>().AddAsync(entity2);
                            if (enumSUDT3 == EnumSaveUpdateDelete.Save) await context.Set<T3>().AddAsync(entity3);
                            if (enumSUDT4 == EnumSaveUpdateDelete.Save) await context.Set<T4>().AddAsync(entity4);
                            if (enumSUDT5 == EnumSaveUpdateDelete.Save) await context.Set<T5>().AddAsync(entity5);

                            if (enumSUDT1 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity1).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity1).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity2).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity2).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity3).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity3).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT4 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T4>().Attach(entity4);
                                context.Entry(entity4).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity4).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity4).Property(propActiveBool.Name).IsModified = true;
                            }
                            if (enumSUDT5 == EnumSaveUpdateDelete.Delete)
                            {
                                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                                context.Set<T5>().Attach(entity5);
                                context.Entry(entity5).State = EntityState.Unchanged;
                                if (propUpdateDate != null) context.Entry(entity5).Property(propUpdateDate.Name).IsModified = true;
                                if (propActiveBool != null) context.Entry(entity5).Property(propActiveBool.Name).IsModified = true;
                            }

                            if (enumSUDT1 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T1>().Attach(entity1);
                                context.Entry(entity1).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT1)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity1).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT2 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T2>().Attach(entity2);
                                context.Entry(entity2).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT2)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity2).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT3 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T3>().Attach(entity3);
                                context.Entry(entity3).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT3)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity3).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT4 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T4>().Attach(entity4);
                                context.Entry(entity4).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT4)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity4).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            if (enumSUDT5 == EnumSaveUpdateDelete.Update)
                            {
                                context.Set<T5>().Attach(entity5);
                                context.Entry(entity5).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNullT5)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity5).Property(property.Name).IsModified = true;
                                    }
                                }
                            }
                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1,entity2,entity3,entity4,entity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        private T SetEntityPreparation<T>(T entity, EnumSaveUpdateDelete saveUpdateDelete) where T : class
        {
            if (saveUpdateDelete == EnumSaveUpdateDelete.Save)
                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(entity);
            else if (saveUpdateDelete == EnumSaveUpdateDelete.Update)
                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(entity);
            else
                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["deleteactivebool"].SetPreparationEntity<T>(entity);
            return entity;
        }
    }
}
