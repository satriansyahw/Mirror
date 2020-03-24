using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace EFHelper.ColumnHelper
{
    public class ColumnPropGet
    {
        private static ColumnPropGet instance;
        private readonly int nullDatetime = 1;
        public ColumnPropGet()
        {

        }
        public static ColumnPropGet GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ColumnPropGet();
                return instance;
            }
        }
        public T GetClassWithNUllDefaultValue<T>()where T:class
        {
            T entity = Activator.CreateInstance<T>();
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                string fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                string myFieldType = property.PropertyType.Name.ToLower();
                myFieldType = ColumnProperties.GetInstance.IsNullableField(myFieldType) ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;
                bool isNull = ColumnProperties.GetInstance.IsNullableField(fullName);
                if(property.CanWrite)
                {
                    property.SetValue(entity, TypeBantuan.GetInstance.DictTypes[myFieldType].GetActuallyNullValue(isNull));
                }
            }
            return entity;
        }

        public List<ConvertNoToNamePI> GetColumnConvertPI<T>(List<ColumnConvertNoToName> listColumnConvert) where T : class
        {
            var result = new List<ConvertNoToNamePI>();
            foreach (var item in listColumnConvert)
            {
                var sourcePI = ColumnPropGet.GetInstance.GetColumnProps<T>(item.SourceColumnNo);
                var targetPI = ColumnPropGet.GetInstance.GetColumnProps<T>(item.TargetColumnName);
                result.Add(new ConvertNoToNamePI { SourceNoPropertyInfo = sourcePI, TargetNamePropertyInfo = targetPI });
            }
            return result;
        }
        public List<T> GetInstanceWithIDColumnList<T>(List<int> listIDIdentity) where T : class
        {
            List<T> listEntity = new List<T>();
            foreach (var IDIdentity in listIDIdentity)
            {
                T entity = Activator.CreateInstance<T>();
                if (entity != null)
                {
                    ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                    listEntity.Add(entity);
                }
            }
            return listEntity;
        }
        public List<ColumnListInfo> GetColumnList(Type t)
        {
            List<ColumnListInfo> list = new List<ColumnListInfo>();
            var entity = Activator.CreateInstance(t);
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                string colName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                list.Add(new ColumnListInfo { ColName = colName, ColPropInfo = property });
            }
            return list;
        }
        public List<ColumnListInfo> GetColumnList<T>() where T : class
        {
            List<ColumnListInfo> list = new List<ColumnListInfo>();
            T entity = (T)Activator.CreateInstance(typeof(T));
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                string colName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                list.Add(new ColumnListInfo { ColName = colName, ColPropInfo = property });
            }
            return list;
        }
       
        public List<PropertyInfo> GetPropertyColNullOnly<T>(T entity) where T : class
        {
           
            string fullName = string.Empty;
            List<PropertyInfo> resultAwal = new List<PropertyInfo>();
            List<PropertyInfo> result = new List<PropertyInfo>();
            //looking from null value column
            resultAwal = (from sa in entity.GetType().GetProperties().AsQueryable() where sa.GetValue(entity) == null select sa).ToList();
            foreach (PropertyInfo property in resultAwal)
            {
                result.Add(property);
            }

            // check datetime where date year ==1 equals to null datetime
            var resultDatetimeNull = (from sa in entity.GetType().GetProperties().AsQueryable() where sa.GetValue(entity) != null select sa).ToList();
            foreach (PropertyInfo property in resultDatetimeNull)
            {
                fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                string myFieldType = property.PropertyType.Name.ToLower();
                myFieldType = ColumnProperties.GetInstance.IsNullableField(myFieldType) ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;
                object checkValue = property.GetValue(entity);
                if (this.GetIsPrimaryKey<T>(myFieldName))
                {
                    result.Add(property);
                }
                else if (myFieldType == "datetime" & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayUpdateDate)
                    & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayInsertDate))
                {
                   
                    if (!TypeBantuan.GetInstance.DictTypes[myFieldType].IsActuallyNullData(checkValue))
                    {
                        result.Add(property);
                    }

                }
                else if (myFieldType == "boolean" & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayActiveBool))
                {
                    result.Add(property);
                }
                else
                {
                    if (TypeBantuan.GetInstance.DictTypes[myFieldType].IsActuallyNullData(checkValue))
                    {
                        result.Add(property);
                    }

                }
            }
            return result;
        }
        public List<PropertyInfo> GetPropertyColNotNull<T>(T entity) where T : class
        {
            string fullName = string.Empty;
            List<PropertyInfo> resultAwal = new List<PropertyInfo>();
            List<PropertyInfo> result = new List<PropertyInfo>();
            resultAwal = (from sa in entity.GetType().GetProperties().AsQueryable() where sa.GetValue(entity) != null select sa).ToList();
            foreach (PropertyInfo property in resultAwal)
            {
                fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                string myFieldType = property.PropertyType.Name.ToLower();
                myFieldType = ColumnProperties.GetInstance.IsNullableField(myFieldType) ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;

                object checkValue = property.GetValue(entity);
                if (myFieldType == "datetime" & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayUpdateDate)
                     & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayInsertDate) & !this.GetIsPrimaryKey<T>(myFieldName))
                {
                    
                    if(!TypeBantuan.GetInstance.DictTypes[myFieldType].IsActuallyNullData(checkValue))
                    {
                        result.Add(property);
                    }                   

                }
                else if (myFieldType == "datetime" & ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayUpdateDate)
                    & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayInsertDate) & !this.GetIsPrimaryKey<T>(myFieldName))
                {
                    if (property.CanWrite)
                    {
                        property.SetValue(entity, (object)DateTime.Now);
                    }
                    result.Add(property);

                }
                else if (myFieldType != "datetime" & !ColumnProperties.GetInstance.IsColumn(myFieldName, "activebool", "boolactive", "insertby", "insertbyid") 
                    & !this.GetIsPrimaryKey<T>(myFieldName))
                {
                    if (!TypeBantuan.GetInstance.DictTypes[myFieldType].IsActuallyNullData(checkValue))
                    {
                        result.Add(property);
                    }
                }

            }
            return result;
        }
        public PropertyInfo GetColumnProps<T>(params string[] colnames) where T : class
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo pi = null;
            for (int i = 0; i < colnames.Count(); i++)
            {
                string colname = colnames[i].Trim().ToLower();
                string myProp = string.Empty;
                foreach (var property in entity.GetType().GetRuntimeProperties())
                {
                    if (!string.IsNullOrEmpty(property.Name))
                    {
                        colname = ColumnProperties.GetInstance.GetClearFieldName(colname);
                        myProp = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                        if (myProp == colname.Trim())
                        {
                            pi = property;
                        }
                    }
                    if (pi != null)
                    {

                        break;
                    }
                }
                if (pi != null)
                {

                    break;
                }
            }


            return pi;
        }
        public PropertyInfo GetColumnProps(Type t, params string[] colnames)
        {
            var entity = Activator.CreateInstance(t);
            PropertyInfo pi = null;
            for (int i = 0; i < colnames.Count(); i++)
            {
                string colname = colnames[i].Trim().ToLower();
                string myProp = string.Empty;
                foreach (var property in entity.GetType().GetRuntimeProperties())
                {
                    if (!string.IsNullOrEmpty(property.Name))
                    {
                        colname = ColumnProperties.GetInstance.GetClearFieldName(colname);
                        myProp = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                        if (myProp == colname.Trim())
                        {
                            pi = property;
                        }
                    }
                    if (pi != null)
                    {

                        break;
                    }
                }
                if (pi != null)
                {

                    break;
                }
            }


            return pi;
        }
        public PropertyInfo GetColumnProps<T>(string colname) where T : class
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo pi = null;
            colname = colname.Trim().ToLower();
            string myProp = string.Empty;
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                if (!string.IsNullOrEmpty(property.Name))
                {
                    colname = ColumnProperties.GetInstance.GetClearFieldName(colname);
                    myProp = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                    if (myProp == colname.Trim())
                    {
                        pi = property;
                    }
                }
                if (pi != null)
                {

                    break;
                }

            }

            return pi;
        }
        public PropertyInfo GetColumnProps(Type t, string colname)
        {
            var entity = Activator.CreateInstance(t);
            PropertyInfo pi = null;
            colname = colname.Trim().ToLower();
            string myProp = string.Empty;
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                if (!string.IsNullOrEmpty(property.Name))
                {
                    colname = ColumnProperties.GetInstance.GetClearFieldName(colname);
                    myProp = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                    if (myProp == colname.Trim())
                    {
                        pi = property;
                    }
                }
                if (pi != null)
                {

                    break;
                }

            }
            return pi;
        }
        public bool GetCheckIsDBCommandList<T>(List<SearchField> lsf) where T : class
        {
            //check if like
           
            bool result = MiscClass.MiscClass.IsUsingADODBCommandList;
            string colName = string.Empty;
            string queryOperator = string.Empty;

            if (!result) // check to direct properties
            {
                //like,datetime
                foreach (var item in lsf)
                {
                    if (!string.IsNullOrEmpty(item.Name) & !string.IsNullOrEmpty(item.Operator) & item.Value != null)
                    {
                        queryOperator = item.Operator.ToLower().Trim();
                        if (queryOperator == "like")
                        {
                            result = true;
                            break;
                        }
                        else
                        {
                            colName = item.Name.ToString().ToLower().Trim().Replace(@"""", "").Replace("'", "");
                            var colProp = this.GetColumnProps<T>(colName);
                            if (colProp != null)
                            {
                                string fullName = colProp.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                                string myFieldType = colProp.PropertyType.Name.ToLower();
                                bool isnullData = ColumnProperties.GetInstance.IsNullableField(myFieldType);
                                myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType.ToLower().Trim();
                                if (myFieldType == "datetime")
                                {
                                    result = true;
                                    break;
                                }
                            }
                        }
                    }


                }
            }
            return result;
        }
        public bool GetCheckIsDBCommandList(List<SearchField> lsf, Type t)
        {
            //check if like
            bool result = false;
            string colName = string.Empty;
            string queryOperator = string.Empty;
            //like,datetime
            foreach (var item in lsf)
            {
                if (!string.IsNullOrEmpty(item.Name) & !string.IsNullOrEmpty(item.Operator) & item.Value != null)
                {
                    queryOperator = item.Name.ToLower().Trim();
                    if (queryOperator == "like")
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        colName = item.Name.ToString().ToLower().Trim().Replace(@"""", "").Replace("'", "");
                        var colProp = this.GetColumnProps(t, colName);
                        if (colProp != null)
                        {
                            string fullName = colProp.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                            string myFieldType = colProp.PropertyType.Name.ToLower();
                            bool isnullData = ColumnProperties.GetInstance.IsNullableField(myFieldType);
                            myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType.ToLower().Trim();
                            if (myFieldType == "datetime")
                            {
                                result = true;
                                break;
                            }
                        }
                    }
                }


            }
            return result;
        }
        public PropertyInfo GetIdentityColumnProps(Type t)
        {
            var entity = Activator.CreateInstance(t);
            PropertyInfo pi = null;
            foreach (PropertyInfo property in entity.GetType().GetRuntimeProperties())
            {
                var attributes = property.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DatabaseGeneratedAttribute));
                foreach (var attribute in attributes)
                {
                    if (((DatabaseGeneratedAttribute)attribute).DatabaseGeneratedOption.ToString().ToLower() == "identity")
                    {
                        pi = property;
                        break;
                    }
                }

                if (pi != null)
                    break;
            }
            pi = pi ?? entity.GetType().GetRuntimeProperties().ToList()[0];// jika null ambil property yang ke 0
            return pi;
        }
        public PropertyInfo GetIdentityColumnProps<T>() where T : class
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo pi = null;
            foreach (PropertyInfo property in entity.GetType().GetRuntimeProperties())
            {
                var attributes = property.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DatabaseGeneratedAttribute));
                foreach (var attribute in attributes)
                {
                    if (((DatabaseGeneratedAttribute)attribute).DatabaseGeneratedOption.ToString().ToLower() == "identity")
                    {
                        pi = property;
                        break;
                    }
                }

                if (pi != null)
                    break;
            }
            pi = pi ?? entity.GetType().GetRuntimeProperties().ToList()[0];// jika null ambil property yang ke 0
            return pi;
        }
        public bool GetIsPrimaryKey<T>(string fieldName) where T : class
        {
            bool result = false;
            var propIdentity = this.GetIdentityColumnProps<T>();
            if (propIdentity != null)
            {
                string myfieldName = ColumnProperties.GetInstance.GetClearFieldName(propIdentity.Name);
                fieldName = ColumnProperties.GetInstance.GetClearFieldName(fieldName);
                if (fieldName == myfieldName)
                    result = true;
            }
            return result;
        }
        public bool GetIsPrimaryKey(Type t, string fieldName)
        {
            bool result = false;
            var propIdentity = this.GetIdentityColumnProps(t);
            if (propIdentity != null)
            {
                string myfieldName = ColumnProperties.GetInstance.GetClearFieldName(propIdentity.Name);
                fieldName = ColumnProperties.GetInstance.GetClearFieldName(fieldName);
                if (fieldName == myfieldName)
                    result = true;
            }
            return result;
        }
        public bool GetIsNullDatetime<T>(PropertyInfo propertyDatetime, T entity) where T : class
        {
            bool result = false;    //result= false, it's not null datetime, else null datetime      
            if (entity == null || propertyDatetime == null)
                return true;
            object objdatetTime = propertyDatetime.GetValue(entity);
            if(objdatetTime !=null)
            {
                if(this.GetColumnType(propertyDatetime) == "datetime")
                {
                    if(((DateTime)objdatetTime).Date.Year == nullDatetime)
                    {
                        result = true;
                    }
                }
            }
            if (objdatetTime == null) result = true;
            return result;        
        }

        public string GetColumnType(PropertyInfo property)
        {
            string fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
            string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
            string myFieldType = property.PropertyType.Name.ToLower();
            bool isnullData = ColumnProperties.GetInstance.IsNullableField(myFieldType);
            myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;
            return myFieldType;
        }
        public string GetColumnDBType(PropertyInfo property)
        {
            string fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
            string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
            string myFieldType = property.PropertyType.Name.ToLower();
            bool isnullData = ColumnProperties.GetInstance.IsNullableField(myFieldType);
            myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;
            return myFieldType;
        }
        public Expression<Func<TSource, TResult>> GetSelectedColumnExpression<TSource, TResult>() where TSource : class where TResult : class
        {
            Expression<Func<TSource, TResult>> result = null;
             string itemlist = string.Empty;
            string itemcheck = string.Empty;
            var sourceType = typeof(TSource);
            var resultType = typeof(TResult);
            var listColSource = this.GetColumnList(typeof(TSource));
            var listColResult = this.GetColumnList(typeof(TResult));
            var listMemberInfo = (from a in listColResult
                                  join b in listColSource on a.ColName equals b.ColName
                                  select (MemberInfo)b.ColPropInfo);// mencari member info dari TResult                   

            if (listMemberInfo != null)
            {
                var parameter = Expression.Parameter(sourceType, "e");
                var bindings = listMemberInfo.Select(member => Expression.Bind(
                    resultType.GetProperty(member.Name), Expression.MakeMemberAccess(parameter, member)));
                var body = Expression.MemberInit(Expression.New(resultType), bindings);
                result = Expression.Lambda<Func<TSource, TResult>>(body, parameter);
            }
            return result;

        }
        public Expression GetSelectedColumnExpression(Type tSource,Type tResult) 
        {
            Expression result = null;
            string itemlist = string.Empty;
            string itemcheck = string.Empty;
            var sourceType = tSource;
            var resultType = tResult;
            var listColSource = this.GetColumnList(tSource);
            var listColResult = this.GetColumnList(tResult);
            var listMemberInfo = (from a in listColResult
                                  join b in listColSource on a.ColName equals b.ColName
                                  select (MemberInfo)b.ColPropInfo);// mencari member info dari TResult                   

            if (listMemberInfo != null)
            {
                var parameter = Expression.Parameter(sourceType, "e");
                var bindings = listMemberInfo.Select(member => Expression.Bind(
                    resultType.GetProperty(member.Name), Expression.MakeMemberAccess(parameter, member)));
                var body = Expression.MemberInit(Expression.New(resultType), bindings);
                result = Expression.Lambda(body, parameter);
            }
            return result;

        }
    }
}
