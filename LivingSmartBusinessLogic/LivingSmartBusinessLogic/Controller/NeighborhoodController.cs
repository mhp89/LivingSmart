using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
    /// <summary>
    /// Nabolagscontroller
    /// </summary>
    /// <author>Mathias Pousen</author>
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
        /// <summary>
        /// Henter et givent nabolag
        /// </summary>
        /// <param name="zipCode"></param>
        /// <param name="hoodId"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public Neighborhood GetHood(int zipCode, int hoodId)
        {
            return neighborhoodCatalog.GetHood(zipCode, hoodId);
        }
        /// <summary>
        /// Henter alle nabolag indenfor et givent postnummer
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public ReadOnlyCollection<Neighborhood> GetHoods(int zipCode)
        {
            return neighborhoodCatalog.GetHoods(zipCode);
        }

	}
}
