using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgentController
    {
        private EstateAgentCatalog estateAgentCatalog;

        public EstateAgentController()
        {
            estateAgentCatalog = new EstateAgentCatalog();
        }

        public void AddEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.AddToCatalog(estateAgent);
        }

        public EstateAgent MakeNewEstateAgent()
        {
            return new EstateAgent();
        }

        public EstateAgent ReadEstateAgent(int id)
        {
            return estateAgentCatalog.Check(id);
        }

        public void UpdateEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.Save(estateAgent);
        }
    }
}
