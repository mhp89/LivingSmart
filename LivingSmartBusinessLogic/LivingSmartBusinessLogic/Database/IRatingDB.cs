using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IRatingDB
    {
        List<Rating> ReadRatings(int caseId);
        Dictionary<int, List<Rating>> ReadRatings();
        void UpdateRating(Rating rating, int caseId);
        int CreateRating(Rating rating, int caseId);
    }
}
