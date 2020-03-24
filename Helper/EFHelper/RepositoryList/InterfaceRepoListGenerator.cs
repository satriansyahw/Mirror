using EFHelper.Filtering;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryList
{
    public interface InterfaceRepoList
    {
        EFReturnValue ListData<T>() where T : class;
        EFReturnValue ListData<T>(List<SearchField> searchFieldList) where T : class;
        EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;
    }
    public interface InterfaceRepoListAsync
    {
        Task<EFReturnValue> ListDataAsync<T>() where T : class;
        Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class;
        Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        Task<EFReturnValue>ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;

    }

    public interface InterfaceRepoListWithEmpInfo
    {

        EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where T : class where TNoToName : class, IConvertNoToName;
        EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList) 
            where T : class where TNoToName : class, IConvertNoToName;
        EFReturnValue ListDataWithEmpInfo<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) 
            where T : class where TNoToName : class, IConvertNoToName;
        EFReturnValue ListDataWithEmpInfo<TSource, TResult, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class where TResult : class where TNoToName : class,IConvertNoToName;
    }

    public interface InterfaceRepoListWithEmpInfoAsync
    {

        Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
            where T : class where TNoToName : class, IConvertNoToName;
        Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList)
            where T : class where TNoToName : class, IConvertNoToName;
        Task<EFReturnValue> ListDataWithEmpInfoAsync<T, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where T : class where TNoToName : class, IConvertNoToName;
        Task<EFReturnValue> ListDataWithEmpInfoAsync<TSource, TResult, TNoToName>(List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class where TResult : class where TNoToName : class, IConvertNoToName;
    }
    public interface InterfaceRepoListQueryable
    {
        EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable) where TResult : class;
        EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList) where TResult : class;
        EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class;
    }
    public interface InterfaceRepoListQueryableWithEmpInfo
    {
        EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert) where TResult : class where TNoToName : class, IConvertNoToName;
        EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList) where TResult : class where TNoToName : class, IConvertNoToName;
        EFReturnValue ListDataQueryableWithEmpInfo<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class where TNoToName : class, IConvertNoToName;
    }
    public interface InterfaceRepoListQueryableWithEmpInfoAsync
    {
        Task<EFReturnValue> ListDataQueryableWithEmpInfoAsync<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert) where TResult : class where TNoToName : class, IConvertNoToName;
        Task<EFReturnValue> ListDataQueryableWithEmpInfoAsync<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList) where TResult : class where TNoToName : class, IConvertNoToName;
        Task<EFReturnValue> ListDataQueryableWithEmpInfoAsync<TResult, TNoToName>(IQueryable<TResult> queryable, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class where TNoToName : class, IConvertNoToName;
    }
    public interface InterfaceRepoListQueryableAsync
    {
        Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable) where TResult : class;
        Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList) where TResult : class;
        Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class;
    }
    public interface IConvertNoToName
    {
        string EmpNo { get; set; }
        string EmpName { get; set; }

    }
    public interface IRepoListMiscHelper
    {
        string ConvertNoToNameProcessSingle<T, TNoToName>(List<TNoToName> listTableConvert, PropertyInfo targetColNamePI, string strNo)
          where T : class where TNoToName : class, IConvertNoToName;
         string ConvertNoToNameProcessArray<T, TNoToName>(List<TNoToName> listTableConvert, PropertyInfo targetColNamePI, string strNo)
      where T : class where TNoToName : class, IConvertNoToName;

    }

 
}
