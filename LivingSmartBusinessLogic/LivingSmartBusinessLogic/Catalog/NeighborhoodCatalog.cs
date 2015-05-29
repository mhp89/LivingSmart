using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
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
