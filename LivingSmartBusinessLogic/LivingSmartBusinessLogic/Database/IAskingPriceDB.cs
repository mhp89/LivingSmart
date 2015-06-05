using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface IAskingPriceDB
    {
        /// <summary>
        /// Returns a dictionary containing all the AskingPrices in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the AskingPrices in the database, with CaseId as key and a list of AskingPrices containing that caseId</returns>
        /// <author>René Sørensen</author>
        Dictionary<int, List<AskingPrice>> ReadAskingPrices();

        /// <summary>
        /// Updates the information from an AskingPrice, in the database.
        /// </summary>
        /// <param name="askingPrice">AskingPrice to be updated.</param>
        /// <param name="caseId">CaseId connected to the appointment</param>
        /// <author>René Sørensen</author>
        void UpdateAskingPrice(AskingPrice askingPrice, int caseId);

        /// <summary>
        /// Creates an AskingPrice in the database.
        /// </summary>
        /// <param name="askingPrice">AskingPrice to be created.</param>
        /// <param name="caseId">CaseId connected to the AskingPrice</param>
        /// <returns>Returns the Id of the AskingPrice created.</returns>
        /// <author>René Sørensen</author>
        int CreateAskingPrice(AskingPrice askingPrice, int caseId);
    }
}
