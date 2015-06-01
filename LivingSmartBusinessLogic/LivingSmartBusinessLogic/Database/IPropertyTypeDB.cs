using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IPropertyTypeDB
    {
        /// <summary>
        /// Returns all the PropertyTypes from the database.
        /// </summary>
        /// <returns>Returns a List of all the PropertyTypes.</returns>
        List<PropertyType> ReadPropertyTypes();

        /// <summary>
        /// Updates the information from a PropertyType, in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be updated.</param>
        void UpdatePropertyType(PropertyType propertyType);

        /// <summary>
        /// Creates a new PropertyType in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be created.</param>
        /// <returns>Returns the Id of the PropertyType created.</returns>
        int CreatePropertyType(PropertyType propertyType);
    }
}
