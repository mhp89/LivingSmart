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
    internal class DistanceToDBMSSQL : IDistanceToDB
    {
        public List<DistanceTo> ReadDistanceTos()
        {
            throw new NotImplementedException();
        }

        public void UpdateDistanceTo(DistanceTo distanceTo)
        {
            throw new NotImplementedException();
        }

        public int CreateDistanceTo(DistanceTo distanceTo)
        {
            throw new NotImplementedException();
        }
    }
}
