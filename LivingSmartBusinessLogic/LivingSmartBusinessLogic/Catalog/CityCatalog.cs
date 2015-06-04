using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class CityCatalog
    {
        private Dictionary<int, City> cities;

		private ICityDB db;

        internal CityCatalog()
		{
			db = CityDBFactory.GetDBL();
            cities = new Dictionary<int, City>();

			LoadCatalog();
        }

        internal void LoadCatalog()
		{
			var cityList = db.ReadCities();
			foreach (var city in cityList)
				AddToCatalog(city);
        }

        internal void AddToCatalog(City city)
        {
			if(!cities.ContainsKey(city.ZipCode))
				cities.Add(city.ZipCode, city);
        }
        
        internal City GetCity(int zipCode)
        {
            if (cities.ContainsKey(zipCode))
                return cities[zipCode];
            return null;
        }

		internal ReadOnlyCollection<City> GetCities()
		{
		    var cityList = new List<City>();
		    cityList.AddRange(cities.Values);
			return cityList.AsReadOnly();
		}
    }
}
