using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    class PropertyTypeCatalog
    {
        private List<PropertyType> propertyTypes; 

        internal PropertyTypeCatalog()
        {
            propertyTypes = new List<PropertyType>();
        }

        internal PropertyType Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(PropertyType propertyType)
        {
            throw new NotImplementedException();
        }

        internal void AddToCatalog(PropertyType propertyType)
        {
            propertyTypes.Add(propertyType);
        }

        internal void RemoveFromCatalog(PropertyType propertyType)
        {
            propertyTypes.Remove(propertyType);
        }
    }
}
