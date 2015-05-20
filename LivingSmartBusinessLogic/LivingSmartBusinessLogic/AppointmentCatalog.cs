using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class AppointmentCatalog
    {
        private List<Appointment> appointments;

        public AppointmentCatalog()
        {
            appointments = new List<Appointment>();
        }

        public Appointment Check(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public void AddToCatalog(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        public void RemoveFromCatalog(Appointment appointment)
        {
            appointments.Remove(appointment);
        }
    }
}
