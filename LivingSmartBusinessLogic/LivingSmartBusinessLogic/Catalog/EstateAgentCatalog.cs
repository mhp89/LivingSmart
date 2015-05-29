using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgentCatalog
    {
        private Dictionary<int,EstateAgent> estateAgents;

		private int lastID = 0;

        internal EstateAgentCatalog()
        {
            estateAgents = new Dictionary<int, EstateAgent>();
        }

        internal EstateAgent Check(int id)
        {
	        return estateAgents.FirstOrDefault(a => a.Key == id).Value;
            throw new System.NotImplementedException();
        }

        internal void Save(EstateAgent estateAgent)
        {
            throw new System.NotImplementedException();
        }

        internal void AddToCatalog(EstateAgent estateAgent)
		{
			//TODO: Remove auto ID
	        estateAgent.Id = ++lastID;
            estateAgents.Add(estateAgent.Id, estateAgent);
        }

        internal void RemoveFromCatalog(EstateAgent estateAgent)
        {
            estateAgents.Remove(estateAgent.Id);
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
