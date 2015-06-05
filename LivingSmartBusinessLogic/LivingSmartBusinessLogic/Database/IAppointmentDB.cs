using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAppointmentDB
    {
        /// <summary>
        /// Returns a dictionary containing all the appointments in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the appointments in the database, with estateAgentId as key and a list of appointments containing that estateAgentId</returns>
        /// <author>René Sørensen</author>
        Dictionary<int, List<Appointment>> ReadAppointments();

        /// <summary>
        /// Updates the information from and appointment, in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be updated.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        /// <author>René Sørensen</author>
        void UpdateAppointment(Appointment appointment, int estateAgentId);

        /// <summary>
        /// Creates an appointment in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be created.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        /// <returns>Returns the Id of the Appointment created.</returns>
        /// <author>René Sørensen</author>
        int CreateAppointment(Appointment appointment, int estateAgentId);
    }
}
