using System;
using System.Collections.Generic;

namespace LivingSmartBusinessLogic.Controller
{
    public class EstateAgentController
	{
		#region Singleton

		private static EstateAgentController _instance;
		public static EstateAgentController Instance
		{
			get { return _instance ?? (_instance = new EstateAgentController()); }
		}

		#endregion

        private EstateAgentCatalog estateAgentCatalog;
        private AppointmentCatalog appointmentCatalog;

        private EstateAgent activeEstateAgent;

        public EstateAgentController()
        {
            estateAgentCatalog = new EstateAgentCatalog();
            appointmentCatalog = new AppointmentCatalog();
        }

        #region Methods
        
        public void AddEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.AddToCatalog(estateAgent);
        }

        public EstateAgent MakeNewEstateAgent(string name, string telephone, string email, DateTime startingDate, DateTime terminationDate)
        {
            return new EstateAgent(name, telephone, email, startingDate, terminationDate);
        }

        public EstateAgent ReadEstateAgent(int id)
        {
			return estateAgentCatalog.Check(id);
        }

        public void UpdateEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.Save(estateAgent);
        }

        public void SetName(EstateAgent estateAgent, string name)
        {
            if (estateAgent.Name != name)
                estateAgent.Name = name;
        }

        public void SetTelephone(EstateAgent estateAgent, string telephone)
        {
            if (estateAgent.Telephone != telephone)
                estateAgent.Telephone = telephone;
        }

        public void SetEmail(EstateAgent estateAgent, string email)
        {
            if (estateAgent.Email != email)
                estateAgent.Email = email;
        }

        public void SetStartingDate(EstateAgent estateAgent, DateTime startingDate)
        {
            if (estateAgent.StartingDate != startingDate)
                estateAgent.StartingDate = startingDate;
        }

        public void SetTerminationDate(EstateAgent estateAgent, DateTime startingDate)
        {
            if (estateAgent.TerminationDate != startingDate)
                estateAgent.TerminationDate = startingDate;
        }

		public List<EstateAgent> SearchEstateAgents(int id, string name, string telephone, string email)
		{
			return estateAgentCatalog.SearchEstateAgents(id, name, telephone, email);
        }

        #region Appointment

        public Appointment MakeNewAppointment(int id, Case cCase, DateTime startTimeStamp, DateTime endTimeStamp, string description, string place, Customer customer)
        {
            return new Appointment(id, cCase, startTimeStamp, endTimeStamp, description, place, customer);
        }

        public void AddAppointment(Appointment appointment)
        {
            appointmentCatalog.AddToCatalog(activeEstateAgent.Id, appointment);
        }

        public void RemoveAppointmentFromEstateAgent(Appointment appointment)
        {
            appointmentCatalog.RemoveFromCatalog(activeEstateAgent.Id, appointment);
        }

        public void GetAppointments(Appointment appointment)
        {
            appointmentCatalog.GetAppointments(activeEstateAgent.Id);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            appointmentCatalog.Save(appointment);
        }

        public Appointment ReadAppointment(int id)
        {
            return appointmentCatalog.Check(id);
        }

        /*
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
        public void SetEndTimeStamp(Appointment appointment, DateTime endTimeStamp)
        {
            if (appointment.EndTimeStamp != endTimeStamp)
                appointment.EndTimeStamp = endTimeStamp;
        }
         * 
        */

        #endregion

        #endregion
    }
}
