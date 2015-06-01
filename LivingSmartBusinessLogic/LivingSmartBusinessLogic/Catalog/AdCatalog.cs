using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class AdCatalog
    {
        private Dictionary<int, List<Ad>> adDictionary;

        internal AdCatalog()
        {
            adDictionary = new Dictionary<int, List<Ad>>();
        }

        internal Ad Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Ad ad)
        {
            throw new NotImplementedException();
        }

        internal void AddToCatalog(int caseId, Ad ad)
        {
            if (!adDictionary.ContainsKey(caseId))
                adDictionary.Add(caseId, new List<Ad>());
            adDictionary[caseId].Add(ad);
        }

        internal void RemoveFromCatalog(int caseId, Ad ad)
        {
            adDictionary[caseId].Remove(ad);
        }

        internal ReadOnlyCollection<Ad> GetAds(int caseId)
        {
            return adDictionary[caseId].AsReadOnly();
        }
    }
}
