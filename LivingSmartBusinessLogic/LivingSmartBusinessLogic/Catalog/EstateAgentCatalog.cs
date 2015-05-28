using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgentCatalog
    {
        private Dictionary<int,EstateAgent> estateAgents;

        internal EstateAgentCatalog()
        {
            estateAgents = new Dictionary<int, EstateAgent>();
        }

        internal EstateAgent Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(EstateAgent estateAgent)
        {
            throw new System.NotImplementedException();
        }

        internal void AddToCatalog(EstateAgent estateAgent)
        {
            estateAgents.Add(estateAgent.Id, estateAgent);
        }

        internal void RemoveFromCatalog(EstateAgent estateAgent)
        {
            estateAgents.Remove(estateAgent.Id);
        }
    }
}
