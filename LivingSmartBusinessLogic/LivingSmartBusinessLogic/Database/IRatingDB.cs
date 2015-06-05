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
        /// <summary>
        /// Returns all the PropertyTypes from the database.
        /// </summary>
        /// <returns>Returns a List of all the PropertyTypes.</returns>
        /// <author>René Sørensen</author>
        List<Rating> ReadRatings(int caseId);

        /// <summary>
        /// Returns all the PropertyTypes from the database.
        /// </summary>
        /// <returns>Returns a List of all the PropertyTypes.</returns>
        /// <author>René Sørensen</author>
        Dictionary<int, List<Rating>> ReadRatings();

        /// <summary>
        /// Returns all the PropertyTypes from the database.
        /// </summary>
        /// <returns>Returns a List of all the PropertyTypes.</returns>
        /// <author>René Sørensen</author>
        void UpdateRating(Rating rating, int caseId);

        /// <summary>
        /// Creates a new Rating in the database.
        /// </summary>
        /// <param name="picture">Picture to be created.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        /// <returns>Returns the Id of the Picture created.</returns>
        /// <author>René Sørensen</author>
        int CreateRating(Rating rating, int caseId);
    }
}
