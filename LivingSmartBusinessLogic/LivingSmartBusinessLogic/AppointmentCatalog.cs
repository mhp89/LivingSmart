using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class AppointmentCatalog
    {
        private List<Appointment> appointments;

        internal AppointmentCatalog()
        {
            appointments = new List<Appointment>();
        }

        internal Appointment Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        internal void AddToCatalog(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        internal void RemoveFromCatalog(Appointment appointment)
        {
            appointments.Remove(appointment);
        }
    }
}
