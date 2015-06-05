using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface IPropertyTypeDB
    {
        /// <summary>
        /// Returns all the PropertyTypes from the database.
        /// </summary>
        /// <returns>Returns a List of all the PropertyTypes.</returns>
        /// <author>René Sørensen</author>
        List<PropertyType> ReadPropertyTypes();

        /// <summary>
        /// Updates the information from a PropertyType, in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be updated.</param>
        /// <author>René Sørensen</author>
        void UpdatePropertyType(PropertyType propertyType);

        /// <summary>
        /// Creates a new PropertyType in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be created.</param>
        /// <returns>Returns the Id of the PropertyType created.</returns>
        /// <author>René Sørensen</author>
        int CreatePropertyType(PropertyType propertyType);
    }
}
