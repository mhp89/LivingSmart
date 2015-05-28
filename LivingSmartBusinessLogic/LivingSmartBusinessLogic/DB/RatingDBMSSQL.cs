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
    internal class RatingDBMSSQL : IRatingDB
    {
        public List<PotentialBuyer> ReadRatings()
        {
            throw new NotImplementedException();
        }

        public void UpdateRating(Rating rating)
        {
            throw new NotImplementedException();
        }

        public int CreateRating(Rating rating)
        {
            throw new NotImplementedException();
        }
    }
}
