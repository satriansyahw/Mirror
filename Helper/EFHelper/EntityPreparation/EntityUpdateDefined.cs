using EFHelper.ColumnHelper;

using System.Collections.Generic;

using EFHelper.TypeHelper;
using EFHelper.RepositoryList;
using EFHelper.Filtering;
using System.Reflection;

namespace EFHelper.EntityPreparation
{
    public class EntityUpdateDefined : InterfaceEntityPreparation
    {
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            //update all all field defined in entity ,additonal if forget for updatedate
            TypeBantuan tipe = new TypeBantuan();
            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
            var propUpdateBy = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateBy);
            if (propUpdateDate != null)
                if (propUpdateDate != null)
            {
                if (propUpdateDate.CanWrite)
                {
                    if (ColumnPropGet.GetInstance.GetIsNullDatetime<T>(propUpdateDate, entity))
                    {
                        object objUpdateDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propUpdateDate)].GetDefaultValue(false);
                        propUpdateDate.SetValue(entity, objUpdateDate);
                    }
                }
                if (propUpdateBy != null)
                {
                    if (propUpdateBy.CanWrite)
                    {
                        object objpic = ColumnPropSet.GetInstance.SetColumnPicValue<T>(propUpdateBy, entity);
                        propUpdateBy.SetValue(entity, objpic);

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
