using System.Collections.Generic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface INeighborhoodDB
    {
        /// <summary>
        /// Returns all the Neighborhoods from the database.
        /// </summary>
        /// <returns>Returns a List of all the Neighborhoods from the database.</returns>
        /// <author>René Sørensen</author>
        List<Neighborhood> ReadNeighborhoods();

        /// <summary>
        /// Updates the information from a Neighborhood, in the database.
        /// </summary>
        /// <param name="neighborhood">Neighborhood to be updated.</param>
        /// <author>René Sørensen</author>
        void UpdateNeighborhood(Neighborhood neighborhood);

        /// <summary>
        /// Creates a new Neighborhood in the database.
        /// </summary>
        /// <param name="neighborhood">Neighborhood to be created.</param>
        /// <returns>Returns the Id of the Neighborhood created.</returns>
        /// <author>René Sørensen</author>
        int CreateNeighborhood(Neighborhood neighborhood);
    }
}
