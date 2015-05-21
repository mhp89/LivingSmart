using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgentCatalog
    {
        private Dictionary<int,EstateAgent> estateAgents;

        public EstateAgentCatalog()
        {
            estateAgents = new Dictionary<int, EstateAgent>();
        }

        public EstateAgent Check(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(EstateAgent estateAgent)
        {
            throw new System.NotImplementedException();
        }

        public void AddToCatalog(EstateAgent estateAgent)
        {
            estateAgents.Add(estateAgent.Id, estateAgent);
        }

        public void RemoveFromCatalog(EstateAgent estateAgent)
        {
            estateAgents.Remove(estateAgent.Id);
        }
    }
}
