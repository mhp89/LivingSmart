using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface ICaseDB
    {
        /// <summary>
        /// Returns all the Cases from the database, with a given EstateAgentId.
        /// </summary>
        /// <param name="estateAgentId">Id of the estate agent</param>
        /// <returns>Returns a List of all the Cases, having a EstateAgentId given by the parameter</returns>
        List<Case> ReadCases(int estateAgentId);

		/// <summary>
		/// Returns all the Cases from the database.
		/// </summary>
		/// <returns>Returns a List of all the Cases</returns>
	    List<Case> ReadCases();

        /// <summary>
        /// Updates the information from a Case, in the database.
        /// </summary>
        /// <param name="ca">Case to be updated.</param>
        void UpdateCase(Case ca);

        /// <summary>
        /// Creates a new Case in the database.
        /// </summary>
        /// <param name="ca">Case to be created.</param>
        /// <returns>Returns the Id of the Case created.</returns>
        int CreateCase(Case ca);
    }
}
