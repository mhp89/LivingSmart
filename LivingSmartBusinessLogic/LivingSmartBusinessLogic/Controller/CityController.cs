using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.Controller
{
	public class CityController
	{
		#region Singleton

		private static CityController _instance;
		public static CityController Instance
		{
			get { return _instance ?? (_instance = new CityController()); }
		}

		#endregion

        private CityCatalog cityCatalog;

		private CityController()
        {
            cityCatalog = new CityCatalog();
        }

        public City GetCity(int zipCode)
        {
            return cityCatalog.GetCity(zipCode);
        }

		public ReadOnlyCollection<City> GetCities()
		{
			return cityCatalog.GetCities();
		}
    }
}
