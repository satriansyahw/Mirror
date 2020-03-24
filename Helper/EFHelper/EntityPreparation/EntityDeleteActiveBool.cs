using EFHelper.ColumnHelper;
using EFHelper.Filtering;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using EFHelper.TypeHelper;

namespace EFHelper.EntityPreparation
{
    public class EntityDeleteActiveBool : InterfaceEntityPreparation
    {
        /*this is only for set activebool to false, for physically remove drom table will use direct function from EF*/
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            if (entity != null)
            {
                TypeBantuan tipe = new TypeBantuan();
                var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                if (propUpdateDate != null)
                {
                    if (propUpdateDate.CanWrite)
                    { 
                        object objUpdateDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propUpdateDate)].GetDefaultValue(false);
                        propUpdateDate.SetValue(entity, objUpdateDate);
                    }
                }
                if (propActiveBool != null)
                {
                    if (propActiveBool.CanWrite)
                    {
                        propActiveBool.SetValue(entity, false);
                    }
                }
               
            }
            return entity;
        }
        public List<T> SetPreparationEntity<T>(List<T> listEntity) where T : class
        {
            if(listEntity !=null)
            {
                for (int i = 0; i < listEntity.Count; i++)
                {
                    listEntity[i] = this.SetPreparationEntity<T>(listEntity[i]);
                }
            }
            return listEntity;
        }
    }
}
