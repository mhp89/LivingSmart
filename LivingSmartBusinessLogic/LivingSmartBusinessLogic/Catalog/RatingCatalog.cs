using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
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
            throw new NotImplementedException();
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

        internal Rating GetLastRating(Case cCase)
        {
            return ratingDictionary[cCase.Id].Last();
        }
    }
}
