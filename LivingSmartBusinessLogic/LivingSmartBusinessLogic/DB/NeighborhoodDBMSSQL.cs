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
    internal class NeighborhoodDBMSSQL : INeighborhoodDB
    {
        public List<Document> ReadNeighborhoods()
        {
            throw new NotImplementedException();
        }

        public void UpdateDocument(Neighborhood neighborhood)
        {
            throw new NotImplementedException();
        }

        public int CreateDocument(Neighborhood neighborhood)
        {
            throw new NotImplementedException();
        }
    }
}
