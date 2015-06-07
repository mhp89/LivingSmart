using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Database;
using LivingSmartBusinessLogic.Entity;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Aftalekatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class AppointmentCatalog
    {

        private Dictionary<int, List<Appointment>> appointmentDictionary;
        private IAppointmentDB db;

        internal AppointmentCatalog()
        {
            db = AppointmentDBFactory.GetDBL();
            appointmentDictionary = new Dictionary<int, List<Appointment>>();

            LoadCatalog();
        }

        internal void LoadCatalog()
        {
            var appointmentList = db.ReadAppointments();
            foreach (var appointments in appointmentList)
                foreach (var appointment in appointments.Value)
                {
                    AddToCatalog(appointments.Key, appointment);
                }
        }

        internal Appointment Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Appointment appointment, int estateAgentId)
        {
            if (appointment.Id == -1)
                appointment.Id = db.CreateAppointment(appointment, estateAgentId);
            else
                db.UpdateAppointment(appointment, estateAgentId);
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
