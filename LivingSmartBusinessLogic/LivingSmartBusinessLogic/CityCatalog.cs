using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    class CityCatalog
    {
        private Dictionary<int, City> cities;

        internal CityCatalog()
        {
            cities = new Dictionary<int, City>();
        }

        internal void Load()
        {

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
    }
}
