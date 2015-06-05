using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface INeighborhoodDB
    {
        /// <summary>
        /// Returns all the Neighborhoods from the database.
        /// </summary>
        /// <returns>Returns a List of all the Neighborhoods from the database.</returns>
        List<Neighborhood> ReadNeighborhoods();

        /// <summary>
        /// Updates the information from a Neighborhood, in the database.
        /// </summary>
        /// <param name="neighborhood">Neighborhood to be updated.</param>
        void UpdateNeighborhood(Neighborhood neighborhood);

        /// <summary>
        /// Creates a new Neighborhood in the database.
        /// </summary>
        /// <param name="neighborhood">Neighborhood to be created.</param>
        /// <returns>Returns the Id of the Neighborhood created.</returns>
        int CreateNeighborhood(Neighborhood neighborhood);
    }
}
