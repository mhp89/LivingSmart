using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class CaseCatalog
    {
		private Dictionary<int, Case> cases;

		private ICaseDB db;

        internal CaseCatalog()
		{
			db = CaseDBFactory.GetDBL();
            cases = new Dictionary<int, Case>();

			Load();
        }

        internal void Load()
        {
	        var caseList = db.ReadCases();
			foreach (var cCase in caseList)
				AddToCatalog(cCase);
        }

        internal Case Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(Case cCase)
		{
			//if (cCase.Id == -1)
				//Create
			//else
				//Update
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

	    public ReadOnlyCollection<Case> GetCases()
	    {
            var caseList = cases.Values.ToList();
			return caseList.AsReadOnly();
	    }

        public ReadOnlyCollection<Case> GetOpenCases()
        {
            var caseList = GetCases();
            List<Case> openCases = new List<Case>();

            foreach (Case cCase in caseList)
            {
                if (cCase.Status == Case.CaseStatus.Open.ToString())
                {
                    openCases.Add(cCase);
                }
            }

            return openCases.AsReadOnly();
        }

        public ReadOnlyCollection<Case> GetOpenCases(int estateAgentId)
        {
            var caseList = GetOpenCases();
            List<Case> estateAgentCases = new List<Case>();

            foreach (Case cCase in caseList)
            {
                if (cCase.EstateAgent.Id == estateAgentId)
                {
                    estateAgentCases.Add(cCase);
                }
            }

            return estateAgentCases.AsReadOnly();
        }
    }
}
