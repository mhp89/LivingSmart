using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
	public class PropertyTypeController
    {

        #region Singleton

        private static PropertyTypeController _instance;
        public static PropertyTypeController Instance
        {
            get { return _instance ?? (_instance = new PropertyTypeController()); }
        }

        #endregion

        private PropertyTypeCatalog propertyTypeCatalog;

        private PropertyTypeController()
        {
            propertyTypeCatalog = new PropertyTypeCatalog();
        }

        public PropertyType GetPropertyType(int propertyTypeId)
        {
            return propertyTypeCatalog.GetPropertyType(propertyTypeId);
        }

		public ReadOnlyCollection<PropertyType> GetPropertyTypes()
		{
			return propertyTypeCatalog.GetPropertyTypes();
		} 
    }
}
