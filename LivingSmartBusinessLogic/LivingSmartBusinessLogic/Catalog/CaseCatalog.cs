using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Database;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    /// <summary>
    /// Sagskatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class CaseCatalog
    {
        private Dictionary<int, Case> cases;

        private ICaseDB db;

        internal CaseCatalog()
        {
            db = CaseDBFactory.GetDBL();
            cases = new Dictionary<int, Case>();

            LoadCatalog();
        }
        /// <summary>
        /// Indlæser sager
        /// </summary>
        /// <author>Mathias Petersen</author>
        internal void LoadCatalog()
        {
            var caseList = db.ReadCases();
            foreach (var cCase in caseList)
                AddToCatalog(cCase);
        }

        internal Case Check(int id)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// Gemmer en given sag
        /// </summary>
        /// <param name="cCase"></param>
        /// <author>Mathias Petersen</author>
        internal void Save(Case cCase)
        {
            if (cCase.Id == -1)
                cCase.Id = db.CreateCase(cCase);
            else
                db.UpdateCase(cCase);
        }
        /// <summary>
        /// Tilføjer en given sag til kataloget
        /// </summary>
        /// <param name="cCase"></param>
        /// <author>Mathias Poulsen</author>
        internal void AddToCatalog(Case cCase)
		{
			if (!cases.ContainsKey(cCase.Id))
				cases.Add(cCase.Id, cCase);
        }
        /// <summary>
        /// Fjerner en given sag fra kataloget
        /// </summary>
        /// <param name="caseId"></param>
        /// <author>Mathias Poulsen</author>
        internal void RemoveFromCatalog(int caseId)
        {
            if (cases.ContainsKey(caseId))
                cases.Remove(caseId);
        }
        /// <summary>
        /// Henter en given sag udfra caseId
        /// </summary>
        /// <param name="caseId"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        internal Case GetCase(int caseId)
        {
            if (cases.ContainsKey(caseId))
            {
                return cases[caseId];
            }
            return null;
        }
        /// <summary>
        /// Henter alle cases
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
        public ReadOnlyCollection<Case> GetCases()
        {
            var caseList = new List<Case>();
            caseList.AddRange(cases.Values);
            return caseList.AsReadOnly();
        }
        /// <summary>
        /// Henter en liste med alle åbne sager
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
        public ReadOnlyCollection<Case> GetOpenCases()
        {
            var caseList = GetCases();
            List<Case> openCases = new List<Case>();

            foreach (Case cCase in caseList)
            {
	            if (cCase.Status == Case.CaseStatus.Open)
		            openCases.Add(cCase);
            }

            return openCases.AsReadOnly();
        }
        /// <summary>
        /// Henter åbne sager tilknyttet til et givent mægler id
        /// </summary>
        /// <param name="estateAgentId"></param>
        /// <returns></returns>
        public ReadOnlyCollection<Case> GetOpenCases(int estateAgentId)
        {
            var caseList = GetOpenCases();
            List<Case> estateAgentCases = new List<Case>();

            foreach (Case cCase in caseList)
            {
	            if (cCase.Status == Case.CaseStatus.Open && cCase.EstateAgent.Id == estateAgentId)
		            estateAgentCases.Add(cCase);
            }

            return estateAgentCases.AsReadOnly();
        }
    }
}
