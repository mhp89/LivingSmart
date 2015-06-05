using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Database;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    /// <summary>
    /// Ejendomstypekatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class PropertyTypeCatalog
    {
        private Dictionary<int, PropertyType> propertyTypes;

        private IPropertyTypeDB db;
        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Peterprisen</author>
        internal PropertyTypeCatalog()
        {
            db = PropertyTypeDBFactory.GetDBL();
            propertyTypes = new Dictionary<int, PropertyType>();

            LoadCatalog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Petersen</author>
        internal void LoadCatalog()
        {
            var propertyTypeList = db.ReadPropertyTypes();
            foreach (var propertyType in propertyTypeList)
                AddToCatalog(propertyType);
        }

        internal PropertyType Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(PropertyType propertyType)
        {
            if (propertyType.Id == -1)
                propertyType.Id = db.CreatePropertyType(propertyType);
            else
                db.UpdatePropertyType(propertyType);
        }

        internal void AddToCatalog(PropertyType propertyType)
        {
			if(!propertyTypes.ContainsKey(propertyType.Id))
				propertyTypes.Add(propertyType.Id, propertyType);
        }

        internal void RemoveFromCatalog(PropertyType propertyType)
        {
            if (propertyTypes.ContainsKey(propertyType.Id))
                propertyTypes.Remove(propertyType.Id);
        }

        internal PropertyType GetPropertyType(int propertyTypeId)
        {
            if (propertyTypes.ContainsKey(propertyTypeId))
                return propertyTypes[propertyTypeId];
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
        public ReadOnlyCollection<PropertyType> GetPropertyTypes()
        {
            var cityList = new List<PropertyType>();
            cityList.AddRange(propertyTypes.Values);
            return cityList.AsReadOnly();
        }
    }
}
