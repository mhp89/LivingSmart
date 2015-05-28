using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;

namespace LivingSmartBusinessLogic.DB
{
    internal class EstateAgentDBMSSQL : IEstateAgentDB
    {
        public List<Customer> ReadEstateAgents()
        {
            throw new NotImplementedException();
        }

        public void UpdateEstateAgent(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int CreateEstateAgent(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
