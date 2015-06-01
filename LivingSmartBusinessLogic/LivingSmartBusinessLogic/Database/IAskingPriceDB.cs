using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAskingPriceDB
    {
        /// <summary>
        /// Returns a dictionary containing all the appointments in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the appointments in the database, with estateAgentId as key and a list of appointments containing that estateAgentId</returns>
        List<AskingPrice> ReadAskingPrices(int caseId);

        /// <summary>
        /// Updates the information from and appointment, in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be updated.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        void UpdateAskingPrice(AskingPrice askingPrice, int caseId);

        /// <summary>
        /// Creates an appointment in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be created.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        /// <returns>Returns the Id of the Appointment created.</returns>
        int CreateAskingPrice(AskingPrice askingPrice, int caseId);
    }
}
