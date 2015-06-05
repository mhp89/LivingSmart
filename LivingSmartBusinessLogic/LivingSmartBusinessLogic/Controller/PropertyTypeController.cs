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
    /// <summary>
    /// Ejendomstypecontroller
    /// </summary>
    /// <author>Mathias Pousen</author>
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
        /// <summary>
        /// Henter en given ejendomstype udfra et idnummer
        /// </summary>
        /// <param name="propertyTypeId"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public PropertyType GetPropertyType(int propertyTypeId)
        {
            return propertyTypeCatalog.GetPropertyType(propertyTypeId);
        }
        /// <summary>
        /// Henter alle ejendomstyper
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
		public ReadOnlyCollection<PropertyType> GetPropertyTypes()
		{
			return propertyTypeCatalog.GetPropertyTypes();
		} 
    }
}
