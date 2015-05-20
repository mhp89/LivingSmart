using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class AppointmentController
    {
        private AppointmentCatalog appointmentCatalog;

        public AppointmentController()
        {
            appointmentCatalog = new AppointmentCatalog();
        }

        public Appointment MakeNewAppointment()
        {
            return new Appointment();
        }

        public void AddAppointment(Appointment appointment)
        {
            appointmentCatalog.AddToCatalog(appointment);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            appointmentCatalog.Save(appointment);
        }

        public Appointment ReadAppointment(int id)
        {
            return appointmentCatalog.Check(id);
        }
    }
}
