using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
    class NeighborhoodController
	{
		#region Singleton

		private static NeighborhoodController _instance;
		public static NeighborhoodController Instance
		{
			get { return _instance ?? (_instance = new NeighborhoodController()); }
		}

		#endregion

        private NeighborhoodCatalog neighborhoodCatalog;

        public NeighborhoodController()
        {
            neighborhoodCatalog = new NeighborhoodCatalog();
        }

        public Neighborhood GetHood(int hoodId)
        {
            return neighborhoodCatalog.GetHood(hoodId);
        }

	}
}
