using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DB;

namespace LivingSmartBusinessLogic
{
    class CityCatalog
    {
        private Dictionary<int, City> cities;

		//private ICi db;

        internal CityCatalog()
		{
			//db = CustomerDBFactory.GetDBL();
            cities = new Dictionary<int, City>();
        }

        internal void Load()
		{
			/*var customerList = db.ReadCustomers();
			foreach (var customer in customerList)
				AddToCatalog(customer);*/
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
