using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetail : InterfaceRepoDeleteHeaderDetail
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteHeaderDetail instance;
        public static RepoDeleteHeaderDetail GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteHeaderDetail();
                return instance;
            }
        }
        public virtual EFReturnValue DeleteHeaderDetail<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }        
        public virtual EFReturnValue DeleteHeaderDetail<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2);
                            context.Set<T2>().RemoveRange(listEntity2);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteHeaderDetail<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2);
                            context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3);
                            context.Set<T3>().RemoveRange(listEntity3);


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.getListData<T4>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2);
                            context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3);
                            context.Set<T3>().RemoveRange(listEntity3);
                            context.Set<T4>().AttachRange(listEntity4);
                            context.Set<T4>().RemoveRange(listEntity4);


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.getListData<T4>(IDIdentity, idReferenceColName);
                            List<T5> listEntity5 = this.getListData<T5>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2);
                            context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3);
                            context.Set<T3>().RemoveRange(listEntity3);
                            context.Set<T4>().AttachRange(listEntity4);
                            context.Set<T4>().RemoveRange(listEntity4);
                            context.Set<T5>().AttachRange(listEntity5);
                            context.Set<T5>().RemoveRange(listEntity5);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity,listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        private List<T> getListData<T>(int IDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>();
            param.Add(new SearchField { Name = idReferenceColName, Operator = "=", Value = IDIdentity.ToString() });
            RepoList list = new RepoList();
            var myList = list.ListData<T>(param);
            var myListData = myList.ReturnValue[0].ReturnValue;
            return (myList.IsSuccessConnection & myList.IsSuccessQuery  & myListData.Count > 0) ? myListData : null;
        }
    }
}
