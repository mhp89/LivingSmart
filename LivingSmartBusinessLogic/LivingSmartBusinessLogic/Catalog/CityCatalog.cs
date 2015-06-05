using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Database;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    /// <summary>
    /// City catalog
    /// </summary>
    internal class CityCatalog
    {
        private Dictionary<int, City> cities;

        private ICityDB db;
        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Petersen</author>
        internal CityCatalog()
        {
            db = CityDBFactory.GetDBL();
            cities = new Dictionary<int, City>();

            LoadCatalog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Petersen</author>
        internal void LoadCatalog()
        {
            var cityList = db.ReadCities();
            foreach (var city in cityList)
                AddToCatalog(city);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <author>Mathias Poulsen</author>
        internal void AddToCatalog(City city)
        {
			if(!cities.ContainsKey(city.ZipCode))
				cities.Add(city.ZipCode, city);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        internal City GetCity(int zipCode)
        {
            if (cities.ContainsKey(zipCode))
                return cities[zipCode];
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        internal ReadOnlyCollection<City> GetCities()
        {
            var cityList = new List<City>();
            cityList.AddRange(cities.Values);
            return cityList.AsReadOnly();
        }
    }
}
