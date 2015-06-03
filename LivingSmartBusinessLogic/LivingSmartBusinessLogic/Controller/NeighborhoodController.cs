using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
    public class NeighborhoodController
	{
		#region Singleton

		private static NeighborhoodController _instance;
		public static NeighborhoodController Instance
		{
			get { return _instance ?? (_instance = new NeighborhoodController()); }
		}

		#endregion

        private NeighborhoodCatalog neighborhoodCatalog;

        private NeighborhoodController()
        {
            neighborhoodCatalog = new NeighborhoodCatalog();
        }

        public Neighborhood GetHood(int zipCode, int hoodId)
        {
            return neighborhoodCatalog.GetHood(zipCode, hoodId);
        }

        public ReadOnlyCollection<Neighborhood> GetHoods(int zipCode)
        {
            return neighborhoodCatalog.GetHoods(zipCode);
        }

	}
}
