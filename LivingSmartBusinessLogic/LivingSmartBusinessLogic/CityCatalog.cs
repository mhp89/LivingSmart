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

        internal Case Check(int zipCode)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(City city)
        {
            throw new System.NotImplementedException();
        }

        internal void AddToCatalog(City city)
        {
            cities.Add(city.ZipCode, city);
        }

        internal void RemoveFromCatalog(int zipCode)
        {
            cities.Remove(zipCode);
        }

        internal City GetCity(int zipCode)
        {
            if (cities.ContainsKey(zipCode))
                return cities[zipCode];
            return null;
        }
    }
}
