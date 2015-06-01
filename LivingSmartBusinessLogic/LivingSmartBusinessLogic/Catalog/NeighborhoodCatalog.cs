using System.Collections.Generic;

namespace LivingSmartBusinessLogic.Catalog
{
    class NeighborhoodCatalog
    {
        private Dictionary<int, Neighborhood> neighborhoods;

        public NeighborhoodCatalog()
        {
            neighborhoods = new Dictionary<int, Neighborhood>();
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
    }
}
