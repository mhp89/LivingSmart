using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    /// <summary>
    /// Nabolagskatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class NeighborhoodCatalog
    {
        private Dictionary<int, List<Neighborhood>> neighborhoods;
        private INeighborhoodDB db;

        public NeighborhoodCatalog()
        {
            db = NeighborhoodDBFactory.GetDBL();
            neighborhoods = new Dictionary<int, List<Neighborhood>>();

            LoadCatalog();
        }

        internal void LoadCatalog()
        {
            var neighborhoodList = db.ReadNeighborhoods();
            foreach (var hood in neighborhoodList)
                    AddHood(hood);
        }

        internal void AddHood(Neighborhood hood)
        {
			if(!neighborhoods.ContainsKey(hood.City.ZipCode))
				neighborhoods.Add(hood.City.ZipCode, new List<Neighborhood>());
            neighborhoods[hood.City.ZipCode].Add(hood);
        }

        internal Neighborhood GetHood(int zipCode, int hoodId)
        {
            if (neighborhoods.ContainsKey(zipCode))
                foreach (var hood in neighborhoods[zipCode])
                {
                    if (hood.Id == hoodId)
                    {
                        return hood;
                    }
                }
            return null;
        }

        internal ReadOnlyCollection<Neighborhood> GetHoods(int zipCode)
        {
			if(!neighborhoods.ContainsKey(zipCode))
				return null;

	        var hoodList = neighborhoods[zipCode];
            return hoodList.AsReadOnly();
        }
    }
}
