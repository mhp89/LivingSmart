using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CaseCatalog
    {

        private Dictionary<int,Case> cases;
        //private List<Case> cases;

        public CaseCatalog()
        {
            cases = new Dictionary<int, Case>();
        }

        public void Load()
        {
            
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
            cases.Add(cCase.Id, cCase);
        }

        public void RemoveFromCatalog(int caseId)
        {
            cases.Remove(caseId);
        }

    }
}