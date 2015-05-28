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
        List<Customer> ReadEstateAgents();
        void UpdateEstateAgent(Customer customer);
        int CreateEstateAgent(Customer customer);
    }
}
