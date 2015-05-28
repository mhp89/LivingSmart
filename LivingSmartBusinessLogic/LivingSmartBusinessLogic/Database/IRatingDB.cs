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
        Dictionary<int, List<Rating>> ReadRatings(int caseId);
        void UpdateRating(Rating rating, int caseId, int estateAgentId);
        int CreateRating(Rating rating, int caseId, int estateAgentId);
    }
}
