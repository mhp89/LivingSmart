using System.Collections.Generic;

namespace LivingSmartBusinessLogic.Catalog
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

        internal Case GetCase(int caseId)
        {
            if (cases.ContainsKey(caseId))
            {
                return cases[caseId];
            }
            return null;
        }

    }
}