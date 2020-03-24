using EFHelper.Filtering;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EFHelper.DBCommandList
{
    public interface InterfaceDBCommandListQuery
    {
        string CreateQueryList<T>() where T : class;
        string CreateQueryList<TSource, TResult>() where TSource : class where TResult : class;
        QueryGeneratorResult CreateQueryList<T>(List<SearchField> searchFieldList) where T : class;
        QueryGeneratorResult CreateQueryList<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        QueryGeneratorResult CreateQueryList<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;
    }
    public interface InterfaceDBCommandListGet
    {
        string GetTableName<T>() where T : class;
        string GetSelectFields<T>() where T : class;
        string GetSelectFields<TSource, TResult>() where TSource : class where TResult : class;
        List<SqlParameter> GetWhereParameterCollection<T>(List<SearchField> lsf) where T : class;
        string GetWhereParameterizedQuery<T>(List<SearchField> lsf) where T : class;
        string GetOrderBy<T>(string sortColumn, bool isAscending) where T : class;
        string GetTopQuery(int topTake);
    }
}

