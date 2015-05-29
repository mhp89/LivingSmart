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

        internal CaseCatalog()
        {
            cases = new Dictionary<int, Case>();
        }

        internal void Load()
        {
            
        }

        internal Case Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(Case cCase)
        {
            throw new System.NotImplementedException();
        }

        internal void AddToCatalog(Case cCase)
        {
            cases.Add(cCase.Id, cCase);
        }

        internal void RemoveFromCatalog(int caseId)
        {
            cases.Remove(caseId);
        }
        
    }
}