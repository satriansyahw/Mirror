using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteList : InterfaceRepoDeleteList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteList instance;
        public static RepoDeleteList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteList();
                return instance;
            }
        }
        public virtual EFReturnValue DeleteList<T>(List<T> listEntity) where T : class
        {         
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<T>().AttachRange(listEntity); context.Set<T>().RemoveRange(listEntity);
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
        public virtual EFReturnValue DeleteList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);
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
        public virtual EFReturnValue DeleteList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3); context.Set<T3>().RemoveRange(listEntity3);

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
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 & listEntity4.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3); context.Set<T3>().RemoveRange(listEntity3);
                            context.Set<T4>().AttachRange(listEntity4); context.Set<T4>().RemoveRange(listEntity4);

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
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
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
                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3); context.Set<T3>().RemoveRange(listEntity3);
                            context.Set<T4>().AttachRange(listEntity4); context.Set<T4>().RemoveRange(listEntity4);
                            context.Set<T5>().AttachRange(listEntity5); context.Set<T5>().RemoveRange(listEntity5);

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
        public virtual EFReturnValue DeleteList<T>(List<int> listIDIdentity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);
                            foreach (var item in listEntity1) { context.Set<T>().Attach(item); context.Set<T>().Remove(item); }
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
        public virtual EFReturnValue DeleteList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 =  ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);

                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);

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
        public virtual EFReturnValue DeleteList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 & listIDIdentity3.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            List<T3> listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);

                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3); context.Set<T3>().RemoveRange(listEntity3);

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
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 & listIDIdentity3.Count > 0 & listIDIdentity4.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            List<T3> listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);
                            List<T4> listEntity4 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T4>(listIDIdentity4);

                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3); context.Set<T3>().RemoveRange(listEntity3);
                            context.Set<T4>().AttachRange(listEntity4); context.Set<T4>().RemoveRange(listEntity4);


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
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 & listIDIdentity3.Count > 0 & listIDIdentity4.Count > 0 & listIDIdentity5.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            List<T3> listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);
                            List<T4> listEntity4 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T4>(listIDIdentity4);
                            List<T5> listEntity5 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T5>(listIDIdentity5);

                            context.Set<T1>().AttachRange(listEntity1); context.Set<T1>().RemoveRange(listEntity1);
                            context.Set<T2>().AttachRange(listEntity2); context.Set<T2>().RemoveRange(listEntity2);
                            context.Set<T3>().AttachRange(listEntity3); context.Set<T3>().RemoveRange(listEntity3);
                            context.Set<T4>().AttachRange(listEntity4); context.Set<T4>().RemoveRange(listEntity4);
                            context.Set<T5>().AttachRange(listEntity5); context.Set<T5>().RemoveRange(listEntity5);

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
