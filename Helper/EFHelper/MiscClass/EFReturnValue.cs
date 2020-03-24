using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.MiscClass
{
    public interface InterfaceEFReturnValue
    {
        List<T> ConvertReturnValueToList<T>(EFReturnValue returnValue) where T : class;
        T ConvertReturnValueToClass<T>(EFReturnValue returnValue) where T : class;
        bool ConvertReturnValueToBool(EFReturnValue returnValue);
    }
    public class EFReturnValue:InterfaceEFReturnValue
    {
        public bool IsSuccessConnection { get; set; }
        public bool IsSuccessQuery { get; set; }
        public string ErrorMessage { get; set; }
        public dynamic ReturnValue { get; set; }
        private static EFReturnValue instance;

        public static EFReturnValue GetInstance
        {
            get
            {
                if (instance == null) instance = new EFReturnValue();
                return instance;
            }
        }
        public EFReturnValue SetEFReturnValue(EFReturnValue eFReturn, bool IsSuccessConnection, int hasilSaveChanges, params object[] objectResult)
        {

            if (IsSuccessConnection)
            {
                eFReturn.IsSuccessConnection = true;
                if (hasilSaveChanges > 0)
                {
                    eFReturn.IsSuccessQuery = true;
                    eFReturn.ErrorMessage = string.Empty;
                    List<DictReturnValue> dictReturn = new List<DictReturnValue>();
                    foreach (var item in objectResult)
                    {
                        dictReturn.Add(new DictReturnValue { Name = item.GetType().Name.Replace("`",""), ReturnValue = item });
                    }
                    eFReturn.ReturnValue = dictReturn;
                }
                else
                {
                    eFReturn.IsSuccessQuery = false;
                    eFReturn.ErrorMessage = objectResult.ToString();
                    eFReturn.ReturnValue = null;
                }

            }
            else
            {
                eFReturn.IsSuccessConnection = false;
                eFReturn.IsSuccessQuery = false;
                eFReturn.ErrorMessage = objectResult.ToString();
                eFReturn.ReturnValue = null;

            }
            return eFReturn;
        }
        public class DictReturnValue
        {
            public string Name { get; set; }
            public object ReturnValue { get; set; }
        }
      
        public List<T>ConvertReturnValueToList<T>(EFReturnValue returnValue) where T:class
        {
            List<T> listResult = new List<T>();
            if (returnValue == null) return listResult;
            if (returnValue.IsSuccessConnection & returnValue.IsSuccessQuery)
                listResult = (List<T>)returnValue.ReturnValue[0].ReturnValue;
            return listResult;
        }
        public T ConvertReturnValueToClass<T>(EFReturnValue returnValue) where T : class
        {
            T kelas = Activator.CreateInstance<T>();
            if (returnValue == null) return kelas;
            if (returnValue.IsSuccessConnection & returnValue.IsSuccessQuery)
                kelas = (T)returnValue.ReturnValue[0].ReturnValue;
            return kelas;
        }
        public bool ConvertReturnValueToBool(EFReturnValue returnValue)
        {
            if (returnValue == null) return false;
            if (returnValue.IsSuccessConnection & returnValue.IsSuccessQuery)
                return true;
            return false;
        }
    }
}
