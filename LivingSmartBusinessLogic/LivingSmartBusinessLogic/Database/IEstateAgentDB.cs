using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
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
    }
}
