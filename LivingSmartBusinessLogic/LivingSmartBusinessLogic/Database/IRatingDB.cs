using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IRatingDB
    {
        List<Rating> ReadRatings();
        void UpdateRating(Rating rating);
        int CreateRating(Rating rating);
    }
}
