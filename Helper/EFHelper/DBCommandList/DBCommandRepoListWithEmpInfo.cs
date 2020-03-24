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
using System.Linq;

namespace EFHelper.DBCommandList
{
    public class DBCommandRepoListWithEmpInfo : InterfaceRepoListWithEmpInfo
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        DBCommandListResult convertResult = new DBCommandListResult();
        public virtual EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where T : class where TNoToName : class, IConvertNoToName
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

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                                listResult = convertResult.ConvertDataReaderToListEmpInfo<T, TNoToName>(dataReader, listTableConvert, listColumnConvert);

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
        public virtual EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
            where T : class where TNoToName : class, IConvertNoToName
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
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                                listResult = convertResult.ConvertDataReaderToListEmpInfo<T, TNoToName>(dataReader, listTableConvert, listColumnConvert);
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
        public virtual EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert
            , List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where T : class where TNoToName : class, IConvertNoToName
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
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<T>(searchFieldList, sortColumn, isAscending, topTake);
                        cmd.CommandText = queryResult.SelectQuery;
                        queryResult.ListParameters = queryResult.ListParameters.Distinct().ToList();
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                                listResult = convertResult.ConvertDataReaderToListEmpInfo<T, TNoToName>(dataReader, listTableConvert, listColumnConvert);
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
        public virtual EFReturnValue ListDataWithEmpInfo<TSource, TResult, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class where TResult : class where TNoToName : class, IConvertNoToName
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
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake);
                        cmd.CommandText = queryResult.SelectQuery;
                        queryResult.ListParameters = queryResult.ListParameters.Distinct().ToList();
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<TResult>();
                        List<TResult> listResult = new List<TResult>();
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                                listResult = convertResult.ConvertDataReaderToListEmpInfo<TResult, TNoToName>(dataReader, listTableConvert, listColumnConvert);
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
