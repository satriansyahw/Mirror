using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EFHelper.ColumnHelper;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;

namespace EFHelper.EntityPreparation
{
    public class EntityMultiplePK : InterfaceEntityMultiplePK
    {
        private const string multiplePKAttr = "MultiplePKAttribute";
        private const string multiplePKMember = "IsMultiplePK";
        private const bool isUsingMultiplePK = true;// if false, no checking to multiple PK

        private string multipleErrorMessage = "Error, Violation of Multiple PK, check : ";
        public bool IsContinueSaveAfterMultiplePK<T>(T entity, out EFReturnValue returnValue) where T : class
        {
            // if true, continue to next query
            returnValue = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            bool result = true ;
            if (isUsingMultiplePK)
            {
                List<SearchField> lsfMultiplePK = new List<SearchField>();
                bool isMultiple = this.CheckIsMultiplePKSave<T>(entity, out lsfMultiplePK);
                if (isMultiple)
                {
                    RepoList repoList = new RepoList();
                    var cekList = repoList.ListData<T>(lsfMultiplePK);
                    if (cekList.IsSuccessConnection & cekList.IsSuccessQuery)
                    {
                        if (cekList.ReturnValue.ReturnValue != null)
                        {
                            var dataList = (List<T>)cekList.ReturnValue.ReturnValue;
                            if (dataList != null)
                                if (dataList.Count >= 1)
                                {
                                    result = false;
                                    foreach (var item in lsfMultiplePK)
                                    {
                                        multipleErrorMessage += item.Name + ",";
                                    }
                                    multipleErrorMessage += " columns";
                                    returnValue.SetEFReturnValue(returnValue, false, 0, multipleErrorMessage);
                                }

                        }
                    }

                }
            }
            return result;
        }

        public async Task<bool> IsContinueSaveAfterMultiplePKAsync<T>(T entity) where T : class
        {
            // if true, continue to next query
            bool result = true;
            if (isUsingMultiplePK)
            {
                List<SearchField> lsfMultiplePK = new List<SearchField>();
                bool isMultiple = this.CheckIsMultiplePKSave<T>(entity, out lsfMultiplePK);
                if (isMultiple)
                {
                    RepoListAsync repoList = new RepoListAsync();
                    var cekList = await repoList.ListDataAsync<T>(lsfMultiplePK).ConfigureAwait(false);
                    if (cekList.IsSuccessConnection & cekList.IsSuccessQuery)
                    {
                        if (cekList.ReturnValue.ReturnValue != null)
                        {
                            var dataList = (List<T>)cekList.ReturnValue.ReturnValue;
                            if (dataList != null)
                                if (dataList.Count >= 1)
                                {
                                    result = false;
                                    foreach (var item in lsfMultiplePK)
                                    {
                                        multipleErrorMessage += item.Name + ",";
                                    }
                                    multipleErrorMessage += " columns";
                                }

                        }
                    }

                }
            }
            return result;
        }

        public bool IsContinueUpdateAfterMultiplePK<T>(T entity, out EFReturnValue returnValue) where T : class
        {

            // if true, continue to next query
            returnValue = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            bool result = true;
            if (isUsingMultiplePK)
            {
                List<SearchField> lsfMultiplePK = new List<SearchField>();
                bool isMultiple = this.CheckIsMultiplePKUpdate<T>(entity, out lsfMultiplePK);
                if (isMultiple)
                {
                    RepoList repoList = new RepoList();
                    var cekList = repoList.ListData<T>(lsfMultiplePK);
                    if (cekList.IsSuccessConnection & cekList.IsSuccessQuery)
                    {
                        if (cekList.ReturnValue.ReturnValue != null)
                        {
                            var dataList = (List<T>)cekList.ReturnValue.ReturnValue;
                            if (dataList != null)
                                if (dataList.Count >= 1)
                                {
                                    result = false;
                                    var PIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();// Identity PK/identity PK like, means ordinary position must set to 0 in database table
                                    foreach (var item in lsfMultiplePK)
                                    {
                                        if(item.Name != PIdentity.Name)
                                            multipleErrorMessage += item.Name + " , ";
                                    }
                                    multipleErrorMessage += " columns";
                                    returnValue.SetEFReturnValue(returnValue, false, 0, multipleErrorMessage);
                                }

                        }
                    }

                }
            }
            return result;
        }

        public async Task<bool> IsContinueUpdateAfterMultiplePKAsync<T>(T entity) where T : class
        {
            // if true, continue to next query
            bool result = true;
            if (isUsingMultiplePK)
            {
                List<SearchField> lsfMultiplePK = new List<SearchField>();
                bool isMultiple = this.CheckIsMultiplePKUpdate<T>(entity, out lsfMultiplePK);
                if (isMultiple)
                {
                    RepoListAsync repoList = new RepoListAsync();
                    var cekList = await repoList.ListDataAsync<T>(lsfMultiplePK).ConfigureAwait(false);
                    if (cekList.IsSuccessConnection & cekList.IsSuccessQuery)
                    {
                        if (cekList.ReturnValue.ReturnValue != null)
                        {
                            var dataList = (List<T>)cekList.ReturnValue.ReturnValue;
                            if (dataList != null)
                                if (dataList.Count >= 1)
                                {
                                    result = false;
                                    var PIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();// Identity PK/identity PK like, means ordinary position must set to 0 in database table
                                    foreach (var item in lsfMultiplePK)
                                    {
                                        if (item.Name != PIdentity.Name)
                                            multipleErrorMessage += item.Name + " , ";
                                    }
                                    multipleErrorMessage += " columns";
                                }

                        }
                    }

                }
            }
            return result;
        }

        private bool CheckIsMultiplePKSave<T>(T entity, out List<SearchField> lsfMultiplePK) where T : class
        {
            bool result = false;
            lsfMultiplePK = new List<SearchField>();
            var cekPropWithCustomAttr = (from a in ((PropertyInfo[])entity.GetType().GetProperties()).AsQueryable() where a.CustomAttributes.Count() > 0 select a).ToList();
            var cekPropMultiplePK = cekPropWithCustomAttr.Where(a => a.CustomAttributes.ToList().Any(x => x.AttributeType.ToString().Split(".").Last() == multiplePKAttr
            & x.NamedArguments.ToList().Any(y => y.MemberName == multiplePKMember)// & (bool)y.TypedValue.Value == (bool)true)
            )).ToList();
            if(cekPropMultiplePK.Count > 0)
            {
                result = true;
                foreach (var item in cekPropMultiplePK)
                {
                    SearchField searchField = new SearchField();
                    searchField.Name = item.Name;
                    searchField.Operator = "=";
                    searchField.Value = item.GetValue(entity);
                    lsfMultiplePK.Add(searchField);
                }
            }
            return result;
        }
        private bool CheckIsMultiplePKUpdate<T>(T entity, out List<SearchField> lsfMultiplePK) where T : class
        {
            bool result = false;
            lsfMultiplePK = new List<SearchField>();
            var cekPropWithCustomAttr = (from a in ((PropertyInfo[])entity.GetType().GetProperties()).AsQueryable() where a.CustomAttributes.Count() > 0 select a).ToList();
            var cekPropMultiplePK = cekPropWithCustomAttr.Where(a => a.CustomAttributes.ToList().Any(x => x.AttributeType.ToString().Split(".").Last() == multiplePKAttr
            & x.NamedArguments.ToList().Any(y => y.MemberName == multiplePKMember)// & (bool)y.TypedValue.Value == (bool)true)
            )).ToList();
            var PIdentity =  ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();// Identity PK/identity PK like, means ordinary position must set to 0 in database table
            if (cekPropMultiplePK.Count > 0 & PIdentity != null)  /// multiple PK cannot only be checked if only if the ordinary position > 0
            {
                var cekWithIdentity=  cekPropMultiplePK.Where(a => a.Name == PIdentity.Name).ToList();
                result = true;
                if (cekWithIdentity != null)
                    if (cekWithIdentity.Count > 0)
                        result = false;
           }
           if(result)
           {
                SearchField searchField = new SearchField();
                foreach (var item in cekPropMultiplePK)
                {
                    searchField = new SearchField();
                    searchField.Name = item.Name;
                    searchField.Operator = "=";
                    searchField.Value = item.GetValue(entity);
                    lsfMultiplePK.Add(searchField);
                }
                object PIdentityValue = PIdentity.GetValue(entity);
                searchField = new SearchField();
                searchField.Name = PIdentity.Name;
                searchField.Operator = "<>";
                searchField.Value = PIdentityValue;
                lsfMultiplePK.Add(searchField);

            }

            return result;
        }
    }
}
