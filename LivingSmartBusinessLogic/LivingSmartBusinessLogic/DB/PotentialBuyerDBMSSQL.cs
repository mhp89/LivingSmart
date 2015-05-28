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
    internal class PotentialBuyerDBMSSQL : IPotentialBuyerDB
    {
        public List<PotentialBuyer> ReadPotentialBuyers()
        {
            throw new NotImplementedException();
        }

        public void UpdatePotentialBuyer(PotentialBuyer ca)
        {
            throw new NotImplementedException();
        }

        public int CreatePotentialBuyer(PotentialBuyer ca)
        {
            throw new NotImplementedException();
        }
    }
}
