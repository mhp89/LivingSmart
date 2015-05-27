using System;
using System.Collections.Generic;
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
        public CityController()
        {
            cityCatalog = new CityCatalog();

			//TODO: Remove test data
			cityCatalog.AddToCatalog(new City(7100, "Vejle"));
			cityCatalog.AddToCatalog(new City(5500, "Middelfart"));
			cityCatalog.AddToCatalog(new City(2412, "Julemanden"));
        }

        public City GetCity(int zipCode)
        {
            return cityCatalog.GetCity(zipCode);
        }
    }
}
