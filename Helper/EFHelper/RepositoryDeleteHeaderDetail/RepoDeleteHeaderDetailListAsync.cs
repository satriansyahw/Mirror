using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetailListAsync : InterfaceRepoDeleteHeaderDetailListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteHeaderDetailListAsync instance;
        public static RepoDeleteHeaderDetailListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteHeaderDetailListAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);

                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);

                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }        
        public virtual async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2);
                            context.Set<T2>().RemoveRange(listEntity2);

                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.GetListData<T3>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
                            context.Set<T1>().AttachRange(listEntity1);
                            context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2);
                            context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3);
                            context.Set<T3>().RemoveRange(listEntity3);


                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.GetListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.GetListData<T4>(listIDIdentity, idReferenceColName);

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


                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.GetListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.GetListData<T4>(listIDIdentity, idReferenceColName);
                            List<T5> listEntity5 = this.GetListData<T5>(listIDIdentity, idReferenceColName);

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


                            hasil = await context.SaveChangesAsync().ConfigureAwait(false);
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }

        private List<T> GetListData<T>(List<int> listIDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>
            {
                new SearchField { Name = idReferenceColName, Operator = "in", Value = listIDIdentity }
            };
            RepoList list = new RepoList();
            var myList = list.ListData<T>(param);
            var myListData =(List<T>) myList.ReturnValue[0].ReturnValue;
            return (myList.IsSuccessConnection & myList.IsSuccessQuery  & myListData.Count > 0) ? myListData : null;
        }
    }
}
