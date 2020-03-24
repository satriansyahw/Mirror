using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;
using System.Threading.Tasks;

namespace EFHelper.DBCommandList
{
    public class DBCommandListResult
    {
        List<ConvertNoToNamePI> ListColumnConvertPI = new List<ConvertNoToNamePI>();
        List<ConvertNoToName> ListConvertSelected = new List<ConvertNoToName>();
        RepoListMiscHelper listHelper = new RepoListMiscHelper();

        public DBCommandListResult()
        {

        }
        public List<T> ConvertDataReaderToList<T>(DbDataReader dataReader) where T : class
        {
            List<T> listResult = new List<T>();
            List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
            while (dataReader.Read())
            {
                var classEntity = Activator.CreateInstance<T>();
                foreach (var item in listColumn)
                {
                    int ordinal = dataReader.GetOrdinal(item.ColPropInfo.Name);
                    object value = dataReader.GetValue(ordinal);
                    if (value.GetType() != typeof(System.DBNull))
                    {
                        ColumnPropSet.GetInstance.SetColValue<T>(classEntity, item.ColPropInfo.Name, value);
                    }
                }
                listResult.Add(classEntity);
            }
            return listResult;
        }
        public async Task<List<T>> ConvertDataReaderToListAsync<T>(DbDataReader dataReader) where T : class
        {
            List<T> listResult = new List<T>();
            List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
            while (await dataReader.ReadAsync())
            {
                var classEntity = Activator.CreateInstance<T>();
                foreach (var item in listColumn)
                {
                    int ordinal = dataReader.GetOrdinal(item.ColPropInfo.Name);
                    object value = dataReader.GetValue(ordinal);
                    if (value.GetType() != typeof(System.DBNull))
                    {
                        ColumnPropSet.GetInstance.SetColValue<T>(classEntity, item.ColPropInfo.Name, value);
                    }
                }
                listResult.Add(classEntity);
            }
            return listResult;
        }
        public List<T> ConvertDataReaderToListEmpInfo<T,TNoToName>(DbDataReader dataReader, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert) 
            where T : class
            where TNoToName:class, IConvertNoToName
        {
            List<T> listResult = new List<T>();
            List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
            this.ListColumnConvertPI = ColumnPropGet.GetInstance.GetColumnConvertPI<T>(listColumnConvert);
            while (dataReader.Read())
            {
                var classEntity = Activator.CreateInstance<T>();
                foreach (var item in listColumn)
                {
                    int ordinal = dataReader.GetOrdinal(item.ColPropInfo.Name);
                    object value = dataReader.GetValue(ordinal);
                    if (value.GetType() != typeof(System.DBNull))
                    {
                        ColumnPropSet.GetInstance.SetColValue<T>(classEntity, item.ColPropInfo.Name, value);
                    }

                    foreach (ConvertNoToNamePI itemPI in ListColumnConvertPI)
                    {
                        string strNo = value.ToString().Trim().ToLower();
                        string strName = string.Empty;
                        if(item.ColPropInfo.Name.Trim().ToLower() == itemPI.TargetNamePropertyInfo.Name.Trim().ToLower())
                        {

                            if (strNo.Contains(",") || strNo.Contains("|") || strNo.Contains("^") || strNo.Contains("~"))
                               strName = listHelper.ConvertNoToNameProcessArray<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);
                            else
                               strName = listHelper.ConvertNoToNameProcessSingle<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);

                            ColumnPropSet.GetInstance.SetColValue<T>(classEntity, itemPI.TargetNamePropertyInfo.Name, strName);
                        }

                    }

                }

          

                listResult.Add(classEntity);
            }
            return listResult;
        }
        public async Task<List<T>> ConvertDataReaderToListEmpInfoAsync<T, TNoToName>(DbDataReader dataReader, List<TNoToName> listTableConvert, List<ColumnConvertNoToName> listColumnConvert)
             where T : class
             where TNoToName : class, IConvertNoToName
        {
            List<T> listResult = new List<T>();
            List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
            while (await dataReader.ReadAsync())
            {
                var classEntity = Activator.CreateInstance<T>();
                foreach (var item in listColumn)
                {
                    int ordinal = dataReader.GetOrdinal(item.ColPropInfo.Name);
                    object value = dataReader.GetValue(ordinal);
                    if (value.GetType() != typeof(System.DBNull))
                    {
                        ColumnPropSet.GetInstance.SetColValue<T>(classEntity, item.ColPropInfo.Name, value);
                    }

                    foreach (ConvertNoToNamePI itemPI in ListColumnConvertPI)
                    {
                        string strNo = value.ToString().Trim().ToLower();
                        string strName = string.Empty;
                        if (item.ColPropInfo.Name.Trim().ToLower() == itemPI.TargetNamePropertyInfo.Name.Trim().ToLower())
                        {

                            if (strNo.Contains(",") || strNo.Contains("|") || strNo.Contains("^") || strNo.Contains("~"))
                                strName = listHelper.ConvertNoToNameProcessArray<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);
                            else
                                strName = listHelper.ConvertNoToNameProcessSingle<T, TNoToName>(listTableConvert, itemPI.TargetNamePropertyInfo, strNo);

                            ColumnPropSet.GetInstance.SetColValue<T>(classEntity, itemPI.TargetNamePropertyInfo.Name, strName);
                        }

                    }

                }
                listResult.Add(classEntity);
            }
            return listResult;
        }

    }
}
