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
        public List<EstateAgent> ReadEstateAgents()
        {
            throw new NotImplementedException();
        }

        public void UpdateEstateAgent(EstateAgent estateAgent)
        {
            throw new NotImplementedException();
        }

        public int CreateEstateAgent(EstateAgent estateAgent)
        {
            throw new NotImplementedException();
        }
    }
}
