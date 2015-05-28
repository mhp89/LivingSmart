using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IEstateAgentDB
    {
        List<EstateAgent> ReadEstateAgents();
        void UpdateEstateAgent(EstateAgent estateAgent);
        int CreateEstateAgent(EstateAgent estateAgent);
    }
}
