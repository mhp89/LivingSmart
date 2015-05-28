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
    internal class AskingPriceDBMSSQL : IAskingPriceDB
    {
        public List<AskingPrice> ReadAskingPrices()
        {
            throw new NotImplementedException();
        }

        public void UpdateAskingPrice(AskingPrice askingPrice)
        {
            throw new NotImplementedException();
        }

        public int CreateAskingPrice(AskingPrice askingPrice)
        {
            throw new NotImplementedException();
        }
    }
}
