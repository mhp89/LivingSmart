using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgentCatalog
    {
        private System.Collections.Generic.List<LivingSmartBusinessLogic.EstateAgent> estateAgents;

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
            estateAgents.Add(estateAgent);
        }

        public void RemoveFromCatalog(EstateAgent estateAgent)
        {
            estateAgents.Remove(estateAgent);
        }
    }
}
