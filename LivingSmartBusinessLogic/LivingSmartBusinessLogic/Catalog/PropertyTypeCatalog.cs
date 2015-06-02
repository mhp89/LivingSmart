using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class PropertyTypeCatalog
    {
        private Dictionary<int, PropertyType> propertyTypes;

	    private IPropertyTypeDB db;

        internal PropertyTypeCatalog()
        {
	        db = PropertyTypeDBFactory.GetDBL();
            propertyTypes = new Dictionary<int, PropertyType>();

			Load();
        }
		internal void Load()
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
			//if (propertyType.Id == -1)
				//Create
			//else
				//Update
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

	    public ReadOnlyCollection<PropertyType> GetPropertyTypes()
	    {
		    var cityList = propertyTypes.Values.ToList();
			return cityList.AsReadOnly();
	    }
    }
}
