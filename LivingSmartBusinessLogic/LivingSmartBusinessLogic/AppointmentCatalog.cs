using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class AppointmentCatalog
    {
        private System.Collections.Generic.List<LivingSmartBusinessLogic.Appointment> appointments;

        public Appointment Check(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Appointment appointment)
        {
            throw new System.NotImplementedException();
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
