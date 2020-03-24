using EFHelper.Filtering;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.EntityPreparation
{
    public interface InterfaceEntityPreparation
    {
        T SetPreparationEntity<T>(T entity) where T : class;
        List<T> SetPreparationEntity<T>(List<T> listEntity) where T : class;
    }
    public interface InterfaceEntityMultiplePK
    {
        bool IsContinueSaveAfterMultiplePK<T>(T entity,out EFReturnValue returnValue) where T : class;
        bool IsContinueUpdateAfterMultiplePK<T>(T entity, out EFReturnValue returnValue) where T : class;
        Task<bool> IsContinueSaveAfterMultiplePKAsync<T>(T entity) where T : class;
        Task<bool> IsContinueUpdateAfterMultiplePKAsync<T>(T entity) where T : class;
    }
     

}
