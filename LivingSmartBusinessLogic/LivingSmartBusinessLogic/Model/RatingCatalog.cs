using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Database;
using LivingSmartBusinessLogic.Entity;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Vurderingskatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class RatingCatalog
    {
        private Dictionary<int, List<Rating>> ratingDictionary;
        private IRatingDB db;

        internal RatingCatalog()
        {
            db = RatingDBFactory.GetDBL();
            ratingDictionary = new Dictionary<int, List<Rating>>();

            LoadCatalog();
        }

        internal Rating Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void LoadCatalog()
        {
            var caseRatingList = db.ReadRatings();
            foreach (var ratings in caseRatingList)
                foreach (var rating in ratings.Value)
                {
                    AddToCatalog(ratings.Key, rating);
                }
        }

        internal void Save(Rating rating, int caseId)
        {
            if (rating.Id == -1)
                rating.Id = db.CreateRating(rating, caseId);
            else
                db.UpdateRating(rating, caseId);
        }

        internal void AddToCatalog(int caseId, Rating rating)
        {
            if (!ratingDictionary.ContainsKey(caseId))
				ratingDictionary.Add(caseId, new List<Rating>());
			if (!ratingDictionary[caseId].Contains(rating))
				ratingDictionary[caseId].Add(rating);
        }

        internal void RemoveFromCatalog(int caseId, Rating rating)
        {
            if (ratingDictionary.ContainsKey(caseId))
                ratingDictionary[caseId].Remove(rating);
        }

        internal ReadOnlyCollection<Rating> GetRatings(int caseId)
        {
            return ratingDictionary[caseId].AsReadOnly();
        }

        internal Rating GetLastRating(Case cCase)
        {
            if (!ratingDictionary.ContainsKey(cCase.Id))
                return null;

            return ratingDictionary[cCase.Id][ratingDictionary[cCase.Id].Count - 1];
        }
    }
}
