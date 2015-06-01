using System;
using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class PropertyTypeCatalog
    {
        private Dictionary<int, PropertyType> propertyTypes; 

        internal PropertyTypeCatalog()
        {
            propertyTypes = new Dictionary<int, PropertyType>();
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
            propertyTypes.Add(propertyType.Id, propertyType);
        }

        internal void RemoveFromCatalog(PropertyType propertyType)
        {
            propertyTypes.Remove(propertyType.Id);
        }

        internal PropertyType GetPropertyType(int propertyTypeId)
        {
            if (propertyTypes.ContainsKey(propertyTypeId))
                return propertyTypes[propertyTypeId];
            return null;
        }
    }
}
