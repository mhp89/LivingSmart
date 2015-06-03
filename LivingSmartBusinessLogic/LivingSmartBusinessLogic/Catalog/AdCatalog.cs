using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class AdCatalog
    {
        private Dictionary<int, List<Ad>> adDictionary;
        private IAdDB db;

        internal AdCatalog()
        {
            db = AdDBFactory.GetDBL();
            adDictionary = new Dictionary<int, List<Ad>>();

            LoadCatalog();
        }

        internal void LoadCatalog()
        {
            var adList = db.ReadAds();
            foreach (var ads in adList)
                foreach (var ad in ads.Value)
                {
                    AddToCatalog(ads.Key, ad);
                }
        }

        internal Ad Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Ad ad, int caseId)
        {
            if (ad.Id == -1)
                ad.Id = db.CreateAd(ad, caseId);
            else
                db.UpdateAd(ad, caseId);
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
