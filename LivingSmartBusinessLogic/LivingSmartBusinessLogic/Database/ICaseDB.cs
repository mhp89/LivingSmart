using System.Collections.Generic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface ICaseDB
    {
        /// <summary>
        /// Returns all the Cases from the database, with a given EstateAgentId.
        /// </summary>
        /// <param name="estateAgentId">Id of the estate agent</param>
        /// <returns>Returns a List of all the Cases, having a EstateAgentId given by the parameter</returns>
        /// <author>René Sørensen</author>
        List<Case> ReadCases(int estateAgentId);

		/// <summary>
		/// Returns all the Cases from the database.
		/// </summary>
		/// <returns>Returns a List of all the Cases</returns>
		/// <author>René Sørensen</author>
	    List<Case> ReadCases();

        /// <summary>
        /// Updates the information from a Case, in the database.
        /// </summary>
        /// <param name="ca">Case to be updated.</param>
		/// <author>René Sørensen</author>
        void UpdateCase(Case ca);

        /// <summary>
        /// Creates a new Case in the database.
        /// </summary>
        /// <param name="ca">Case to be created.</param>
        /// <returns>Returns the Id of the Case created.</returns>
        /// <author>René Sørensen</author>
        int CreateCase(Case ca);
    }
}
