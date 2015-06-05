using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface IEstateAgentDB
    {
        /// <summary>
        /// Returns all the EstateAgents from the database.
        /// </summary>
        /// <returns>Returns a List of all the EstateAgents from the database.</returns>
        List<EstateAgent> ReadEstateAgents();

        /// <summary>
        /// Updates the information from an EstateAgent, in the database.
        /// </summary>
        /// <param name="estateAgent">EstateAgent to be updated.</param>
        void UpdateEstateAgent(EstateAgent estateAgent);

        /// <summary>
        /// Creates a new EstateAgent in the database.
        /// </summary>
        /// <param name="estateAgent">EstateAgent to be created.</param>
        /// <returns>Returns the Id of the EstateAgent created.</returns>
        int CreateEstateAgent(EstateAgent estateAgent);

        /// <summary>
        /// Returns an EstateAgent having the specified username and password.
        /// </summary>
        /// <param name="username">username of the estate agent.</param>
        /// <param name="password">password of the estate agent.</param>
        /// <returns></returns>
        EstateAgent LoginEstateAgent(string username, string password);
    }
}
