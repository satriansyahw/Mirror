using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using EFHelper.ColumnHelper;
using EFHelper.Filtering;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace EFHelper.DBCommandList
{
    public class QueryGeneratorResult
    {
        public string SelectQuery { get; set; }
        public List<SqlParameter> ListParameters { get; set; }
    }
    public class DBCommandListQuery : InterfaceDBCommandListQuery
    {
        private static DBCommandListQuery instance;
        private const string select = " select ";
        private const string orderby = " order by ";
        private const string aliasnull = " =null ";
        private const string operatorlike = " like ";
        public static DBCommandListQuery GetInstance
        {
            get
            {
                if (instance == null) instance = new DBCommandListQuery();
                return instance;
            }
        }

        public string CreateQueryList<T>() where T : class
        {
            /*Without Select*/
            string result = string.Empty;      
            string from = " from ";
            string tableName = DBCommandListGet.GetInstance.GetTableName<T>();
            string selectFields = DBCommandListGet.GetInstance.GetSelectFields<T>();
            result = selectFields + from +tableName;
            return result;
        }
        public string CreateQueryList<TSource, TResult>()
            where TSource : class
            where TResult : class
        {
            /*Without Select*/
            string result = string.Empty;
            string from = " from ";
            string tableNameSource = DBCommandListGet.GetInstance.GetTableName<TSource>();
            string selectFields = DBCommandListGet.GetInstance.GetSelectFields<TSource,TResult>();
            result = selectFields + from+tableNameSource;
            return result;
        }
        public QueryGeneratorResult CreateQueryList<T>(List<SearchField> searchFieldList) where T : class
        {
            QueryGeneratorResult result = new QueryGeneratorResult();
            string querybody = this.CreateQueryList<T>();
            string queryWhereParameterized = DBCommandListGet.GetInstance.GetWhereParameterizedQuery<T>(searchFieldList);
            List<SqlParameter> sqlParameters = DBCommandListGet.GetInstance.GetWhereParameterCollection<T>(searchFieldList);
            result.SelectQuery = select + querybody+ queryWhereParameterized;
            result.ListParameters = sqlParameters;
            return result;
        }

        public QueryGeneratorResult CreateQueryList<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            QueryGeneratorResult result = new QueryGeneratorResult();
            string querybody = this.CreateQueryList<T>();
            string queryWhereParameterized = DBCommandListGet.GetInstance.GetWhereParameterizedQuery<T>(searchFieldList);
            string queryOrderBy = DBCommandListGet.GetInstance.GetOrderBy<T>(sortColumn, isAscending);
            string queryTop = DBCommandListGet.GetInstance.GetTopQuery(topTake);
            List<SqlParameter> sqlParameters = DBCommandListGet.GetInstance.GetWhereParameterCollection<T>(searchFieldList);
            result.SelectQuery = select +queryTop+ querybody+queryWhereParameterized+queryOrderBy;
            result.ListParameters = sqlParameters;
            return result;
        }

        public QueryGeneratorResult CreateQueryList<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            QueryGeneratorResult result = new QueryGeneratorResult();
            string querybody =  this.CreateQueryList<TSource,TResult>();
            string queryWhereParameterized = DBCommandListGet.GetInstance.GetWhereParameterizedQuery<TSource>(searchFieldList);
            string queryOrderBy = DBCommandListGet.GetInstance.GetOrderBy<TSource>(sortColumn, isAscending);
            string queryTop = DBCommandListGet.GetInstance.GetTopQuery(topTake);
            List<SqlParameter> sqlParameters = DBCommandListGet.GetInstance.GetWhereParameterCollection<TSource>(searchFieldList);
            result.SelectQuery = select + queryTop + querybody + queryWhereParameterized + queryOrderBy;
            result.ListParameters = sqlParameters;
            return result;
        }
        

        
    }
}
