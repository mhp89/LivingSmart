using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    class CityCatalog
    {
        private Dictionary<int, City> cities;

		private ICityDB db;

        internal CityCatalog()
		{
			db = CityDBFactory.GetDBL();
            cities = new Dictionary<int, City>();

			Load();
        }

        internal void Load()
		{
	        Console.WriteLine("Load cities");
			var cityList = db.ReadCities();
			foreach (var city in cityList)
				AddToCatalog(city);
        }

        internal void AddToCatalog(City city)
        {
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
			var cityList = cities.Values.ToList();
			return cityList.AsReadOnly();
		}
    }
}
