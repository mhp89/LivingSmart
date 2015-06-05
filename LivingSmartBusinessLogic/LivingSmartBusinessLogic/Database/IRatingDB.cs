using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface IRatingDB
    {
        List<Rating> ReadRatings(int caseId);
        Dictionary<int, List<Rating>> ReadRatings();
        void UpdateRating(Rating rating, int caseId);
        int CreateRating(Rating rating, int caseId);
    }
}
