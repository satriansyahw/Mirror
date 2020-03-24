using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public class EntitySave : InterfaceEntityPreparation
    {
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            TypeBantuan tipe = new TypeBantuan();
            var propIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
            var propInsertDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayInsertDate);
            var propInsertBy = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayInsertBy);

            if (propIdentity !=null)
            {
                
                if (propIdentity.CanWrite)
                {
                    object objID = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propIdentity)].GetDefaultValue(false);
                    propIdentity.SetValue(entity, objID);
                }
            }
            if (propActiveBool != null)
            {
                if (propActiveBool.CanWrite)
                {
                    object objActiveBool = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propActiveBool)].GetDefaultValue(false);
                    propActiveBool.SetValue(entity, objActiveBool);
                }
            }
            if (propInsertDate != null)
            {
                if (propInsertDate.CanWrite)
                {
                    if (ColumnPropGet.GetInstance.GetIsNullDatetime<T>(propInsertDate, entity))
                    {
                        object objInsertDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propInsertDate)].GetDefaultValue(false);
                        propInsertDate.SetValue(entity, objInsertDate);
                    }
                }
            }
            if (propInsertBy != null)
            {
                if (propInsertBy.CanWrite)
                {
                    object objpic = ColumnPropSet.GetInstance.SetColumnPicValue<T>(propInsertBy, entity);
                    propInsertBy.SetValue(entity, objpic);                   
                   
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
