namespace LivingSmartBusinessLogic.Controller
{
    public class AppointmentController
    {
        private AppointmentCatalog appointmentCatalog;

        private Appointment activeAppointment;
        
        public AppointmentController()
        {
            appointmentCatalog = new AppointmentCatalog();
        }

        #region Methods
        
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

        public void SetCaseId(Appointment appointment, int caseId)
        {
            if (appointment.CaseId != caseId)
                appointment.CaseId = caseId;
        }
        public void SetDescription(Appointment appointment, string description)
        {
            if (appointment.Description != description)
                appointment.Description = description;
        }
        public void SetPlace(Appointment appointment, string place)
        {
            if (appointment.Place != place)
                appointment.Place = place;
        }
        public void SetCustomer(Appointment appointment, int customerId)
        {
            if (appointment.CustomerId != customerId)
                appointment.CustomerId = customerId;
        }
        public void SetDuration(Appointment appointment, int duration)
        {
            if (appointment.Duration != duration)
                appointment.Duration = duration;
        }

        #endregion
    }
}
