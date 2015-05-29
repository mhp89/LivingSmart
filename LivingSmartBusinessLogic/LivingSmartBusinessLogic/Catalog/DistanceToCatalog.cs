using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    class DistanceToCatalog
    {
        private Dictionary<int, List<DistanceTo>> distanceToDictionary;

        internal DistanceToCatalog()
        {
            distanceToDictionary = new Dictionary<int, List<DistanceTo>>();
        }

        internal DistanceTo Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(DistanceTo distanceTo)
        {
            throw new NotImplementedException();
        }

        internal void AddToCatalog(int caseId, DistanceTo distanceTo)
        {
            if (!distanceToDictionary.ContainsKey(caseId))
                distanceToDictionary.Add(caseId, new List<DistanceTo>());
            distanceToDictionary[caseId].Add(distanceTo);
        }

        internal void RemoveFromCatalog(int caseId, DistanceTo distanceTo)
        {
            distanceToDictionary[caseId].Remove(distanceTo);
        }

        internal ReadOnlyCollection<DistanceTo> GetDistanceTos(int caseId)
        {
            return distanceToDictionary[caseId].AsReadOnly();
        }
    }
}
