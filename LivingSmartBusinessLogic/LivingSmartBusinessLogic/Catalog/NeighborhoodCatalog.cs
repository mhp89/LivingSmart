using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class NeighborhoodCatalog
    {
        private Dictionary<int, Neighborhood> neighborhoods;
        private INeighborhoodDB db;

        public NeighborhoodCatalog()
        {
            db = NeighborhoodDBFactory.GetDBL();
            neighborhoods = new Dictionary<int, Neighborhood>();

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
            neighborhoods.Add(hood.Id, hood);
        }

        internal Neighborhood GetHood(int hoodId)
        {
            if (neighborhoods.ContainsKey(hoodId))
                return neighborhoods[hoodId];
            return null;
        }

        internal ReadOnlyCollection<Neighborhood> GetHoods()
        {
            var hoodList = new List<Neighborhood>();
            hoodList.AddRange(neighborhoods.Values);
            return hoodList.AsReadOnly();
        }
    }
}
