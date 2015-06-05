using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Database;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    /// <summary>
    /// Afstandskatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class DistanceToCatalog
    {
        private Dictionary<int, List<DistanceTo>> distanceToDictionary;
        private IDistanceToDB db;

        internal DistanceToCatalog()
        {
            db = DistanceToDBFactory.GetDBL();
            distanceToDictionary = new Dictionary<int, List<DistanceTo>>();

            LoadCatalog();
        }

        internal void LoadCatalog()
        {
            var distanceList = db.ReadDistanceTos();
            foreach (var distances in distanceList)
                foreach (var distance in distances.Value)
                {
                    AddToCatalog(distances.Key, distance);
                }
        }

        internal DistanceTo Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(DistanceTo distanceTo, int caseId)
        {
            if (distanceTo.Id == -1)
                distanceTo.Id = db.CreateDistanceTo(distanceTo, caseId);
            else
                db.UpdateDistanceTo(distanceTo, caseId);
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
			if(!distanceToDictionary.ContainsKey(caseId))
				return new ReadOnlyCollection<DistanceTo>(new List<DistanceTo>());
            return distanceToDictionary[caseId].AsReadOnly();
        }
    }
}
