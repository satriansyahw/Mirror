using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace EFHelper.DBCommandList
{
    public class DBCommandRepoListAsync : InterfaceRepoListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        DBCommandListResult convertResult = new DBCommandListResult();
        private static DBCommandRepoListAsync instance;
        public static DBCommandRepoListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new DBCommandRepoListAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> ListDataAsync<T>() where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        cmd.CommandText = "select " + DBCommandListQuery.GetInstance.CreateQueryList<T>();

                        List<ColumnListInfo> listColumn =  ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await dataReader.ReadAsync().ConfigureAwait(false))
                            {
                                if (dataReader.HasRows)
                                    listResult =await convertResult.ConvertDataReaderToListAsync<T>(dataReader).ConfigureAwait(false);
                            }
                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<T>(searchFieldList);
                        cmd.CommandText = queryResult.SelectQuery;
                        queryResult.ListParameters = queryResult.ListParameters.Distinct().ToList();
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            if (dataReader.HasRows)
                                listResult = await convertResult.ConvertDataReaderToListAsync<T>(dataReader).ConfigureAwait(false);

                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<T>(searchFieldList,sortColumn,isAscending,topTake);
                        cmd.CommandText = queryResult.SelectQuery;
                        queryResult.ListParameters = queryResult.ListParameters.Distinct().ToList();
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await dataReader.ReadAsync().ConfigureAwait(false))
                            {
                                if (dataReader.HasRows)
                                    listResult = await convertResult.ConvertDataReaderToListAsync<T>(dataReader).ConfigureAwait(false);

                            }
                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<TSource,TResult>(searchFieldList, sortColumn, isAscending, topTake);
                        cmd.CommandText = queryResult.SelectQuery;
                        queryResult.ListParameters = queryResult.ListParameters.Distinct().ToList();
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<TResult>();
                        List<TResult> listResult = new List<TResult>();
                        using (var dataReader =await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await dataReader.ReadAsync().ConfigureAwait(false))
                            {
                                if (dataReader.HasRows)
                                    listResult = await convertResult.ConvertDataReaderToListAsync<TResult>(dataReader).ConfigureAwait(false);
                            }
                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
    }
}
