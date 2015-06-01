using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.DB;

namespace LivingSmartBusinessLogic.Catalog
{
    public class EstateAgentCatalog
    {
        private Dictionary<int,EstateAgent> estateAgents;

		private IEstateAgentDB db;

        internal EstateAgentCatalog()
		{
			db = EstateAgentDBFactory.GetDBL();
            estateAgents = new Dictionary<int, EstateAgent>();

			LoadCatalog();
        }

		internal void LoadCatalog()
		{
			var estateAgentLst = db.ReadEstateAgents();
			foreach (var estateAgent in estateAgentLst)
				AddToCatalog(estateAgent);
		}

        internal EstateAgent Check(int id)
        {
	        return estateAgents.FirstOrDefault(a => a.Key == id).Value;
        }

        internal void Save(EstateAgent estateAgent)
		{
			//TODO: Check for exist
			estateAgent.Id = db.CreateEstateAgent(estateAgent);
        }

        internal void AddToCatalog(EstateAgent estateAgent)
		{
			if (!estateAgents.ContainsKey(estateAgent.Id))
				estateAgents.Add(estateAgent.Id, estateAgent);
        }

        internal void RemoveFromCatalog(EstateAgent estateAgent)
        {
            estateAgents.Remove(estateAgent.Id);
        }


		internal ReadOnlyCollection<EstateAgent> GetEstateAgents()
		{
			var estateAgentList = estateAgents.Values.ToList();
			return estateAgentList.AsReadOnly();
		}

        internal EstateAgent GetEstateAgent(int estateAgentId)
        {
            if (estateAgents.ContainsKey(estateAgentId))
            {
                return estateAgents[estateAgentId];
            }
            return null;
        }

		internal List<EstateAgent> SearchEstateAgents(int id, string name, string telephone, string email)
		{
			List<EstateAgent> result = new List<EstateAgent>();

			foreach (var estateAgent in estateAgents)
			{
				bool success = true;

				if (id != -1 && !estateAgent.Value.Id.ToString().ToLower().Contains(id.ToString().ToLower()))
					success = false;

				if (name != null && !estateAgent.Value.Name.ToLower().Contains(name.ToLower()))
					success = false;

				if (telephone != null && !estateAgent.Value.Telephone.ToLower().Contains(telephone.ToLower()))
					success = false;

				if (email != null && !estateAgent.Value.Email.ToLower().Contains(email.ToLower()))
					success = false;

				if (success)
					result.Add(estateAgent.Value);
			}

			return result;
		}
    }
}
