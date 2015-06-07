using System.Collections.Generic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface ICityDB
    {
        /// <summary>
        /// Returns all the Cities from the database.
        /// </summary>
        /// <returns>Returns a List of all the Cities from the database</returns>
        /// <author>René Sørensen</author>
        List<City> ReadCities();
    }
}
