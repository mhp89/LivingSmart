using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CaseCatalog
    {
        private List<Case> cases;

        public CaseCatalog()
        {
            cases = new List<Case>();
        }

        public Case Check(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Case cCase)
        {
            throw new System.NotImplementedException();
        }

        public void AddToCatalog(Case cCase)
        {
            cases.Add(cCase);
        }

        public void RemoveFromCatalog(Case cCase)
        {
            cases.Remove(cCase);
        }

        public ReadOnlyCollection<Ad> GetAds(Case cCase)
        {
            return cCase.GetAds();
        }
    }
}