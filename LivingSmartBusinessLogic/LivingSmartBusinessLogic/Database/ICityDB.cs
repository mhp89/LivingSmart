using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface ICityDB
    {
        /// <summary>
        /// Returns all the Cities from the database.
        /// </summary>
        /// <returns>Returns a List of all the Cities from the database</returns>
        List<City> ReadCities();
    }
}
