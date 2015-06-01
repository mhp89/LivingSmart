using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class AppointmentCatalog
    {

        private Dictionary<int, List<Appointment>> appointmentDictionary;

        internal AppointmentCatalog()
        {
            appointmentDictionary = new Dictionary<int, List<Appointment>>();
        }

        internal Appointment Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Appointment appointment)
		{
			//if (appointment.Id == -1)
				//Create
			//else
				//Update
        }

        internal void AddToCatalog(int estateAgentId, Appointment appointment)
        {
            if (!appointmentDictionary.ContainsKey(estateAgentId))
                appointmentDictionary.Add(estateAgentId, new List<Appointment>());
            appointmentDictionary[estateAgentId].Add(appointment);
        }

        internal void RemoveFromCatalog(int estateAgentId, Appointment appointment)
        {
            appointmentDictionary[estateAgentId].Remove(appointment);
        }

        internal ReadOnlyCollection<Appointment> GetAppointments(int estateAgentId)
        {
            return appointmentDictionary[estateAgentId].AsReadOnly();
        }
    }
}
