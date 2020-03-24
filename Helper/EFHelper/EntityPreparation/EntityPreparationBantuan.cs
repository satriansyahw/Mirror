using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public class EntityPreparationBantuan
    {
        private static EntityPreparationBantuan instance;
        public EntityPreparationBantuan()
        {
            this.LoadInitialEntiyPreparation();
        }
        public static EntityPreparationBantuan GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new EntityPreparationBantuan();
                return instance;
            }
        }
        public Dictionary<string, InterfaceEntityPreparation> DictEntityPreparation = new Dictionary<string, InterfaceEntityPreparation>();
        private void LoadInitialEntiyPreparation()
        {
            DictEntityPreparation.Add("save", new EntitySave());
            DictEntityPreparation.Add("update", new EntityUpdate());
            DictEntityPreparation.Add("updatedefined", new EntityUpdateDefined());
            DictEntityPreparation.Add("delete", new EntityDeleteActiveBool());
            DictEntityPreparation.Add("deleteactivebool", new EntityDeleteActiveBool());


        }
    }
}
