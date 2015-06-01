using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class DistanceToCatalog
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
