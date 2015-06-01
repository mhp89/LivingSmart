using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    class RatingCatalog
    {
        private Dictionary<int, List<Rating>> ratingDictionary;

        internal RatingCatalog()
        {
            ratingDictionary = new Dictionary<int, List<Rating>>();
        }

        internal Rating Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Rating rating)
		{
			//if (rating.Id == -1)
				//Create
			//else
				//Update
        }

        internal void AddToCatalog(int caseId, Rating rating)
        {
            if (!ratingDictionary.ContainsKey(caseId))
                ratingDictionary.Add(caseId, new List<Rating>());
            ratingDictionary[caseId].Add(rating);
        }

        internal void RemoveFromCatalog(int caseId, Rating rating)
        {
            ratingDictionary[caseId].Remove(rating);
        }

        internal ReadOnlyCollection<Rating> GetRatings(int caseId)
        {
            return ratingDictionary[caseId].AsReadOnly();
        }
    }
}
