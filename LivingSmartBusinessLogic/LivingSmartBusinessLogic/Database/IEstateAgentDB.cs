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
        /// <author>René Sørensen</author>
        List<EstateAgent> ReadEstateAgents();

        /// <summary>
        /// Updates the information from an EstateAgent, in the database.
        /// </summary>
        /// <param name="estateAgent">EstateAgent to be updated.</param>
        /// <author>René Sørensen</author>
        void UpdateEstateAgent(EstateAgent estateAgent);

        /// <summary>
        /// Creates a new EstateAgent in the database.
        /// </summary>
        /// <param name="estateAgent">EstateAgent to be created.</param>
        /// <returns>Returns the Id of the EstateAgent created.</returns>
        /// <author>René Sørensen</author>
        int CreateEstateAgent(EstateAgent estateAgent);

        /// <summary>
        /// Returns an EstateAgent having the specified username and password.
        /// </summary>
        /// <param name="username">username of the estate agent.</param>
        /// <param name="password">password of the estate agent.</param>
        /// <returns>Returns the estate agent with the given username and password, null if no such exist</returns>
        /// <author>René Sørensen</author>
        EstateAgent LoginEstateAgent(string username, string password);
    }
}
