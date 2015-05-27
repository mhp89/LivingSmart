namespace LivingSmartBusinessLogic.Controller
{
    public class AppointmentController
	{
		#region Singleton

		private AppointmentController _instance;
		public AppointmentController Instance
		{
			get { return _instance ?? (_instance = new AppointmentController()); }
		}

		#endregion


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

        public void SetCase(Appointment appointment, Case newCase)
        {
            if (appointment.Case != newCase)
                appointment.Case = newCase;
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
        public void SetCustomer(Appointment appointment, Customer customer)
        {
            if (appointment.Customer != customer)
                appointment.Customer = customer;
        }
        public void SetDuration(Appointment appointment, int duration)
        {
            if (appointment.Duration != duration)
                appointment.Duration = duration;
        }

        #endregion
    }
}
