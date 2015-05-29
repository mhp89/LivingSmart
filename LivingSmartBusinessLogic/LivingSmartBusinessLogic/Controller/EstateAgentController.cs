using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        #region AdminActiveEstateAgent
        public void SetActiveEstateAgent(EstateAgent activEstateAgent)
        {
            this.activeEstateAgent = activEstateAgent;
        }

        public void CancelActiveEstateAgent()
        {
            estateAgentCatalog = null;
        }

		public void SaveActiveEstateAgent()
		{
			estateAgentCatalog.Save(activeEstateAgent);
			AddEstateAgent(activeEstateAgent);
        }
        #endregion

        private void AddEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.AddToCatalog(estateAgent);
        }

        public EstateAgent MakeNewEstateAgent(string name, string telephone, string email, DateTime startingDate)
        {
            SetActiveEstateAgent(new EstateAgent(name, telephone, email, startingDate));
            return activeEstateAgent;
        }

        public EstateAgent ReadEstateAgent(int id)
        {
			return estateAgentCatalog.Check(id);
        }

		public ReadOnlyCollection<EstateAgent> GetEstateAgents()
		{
			return estateAgentCatalog.GetEstateAgents();
		}

        public EstateAgent GetEstateAgent(int estateAgentId)
        {
            return estateAgentCatalog.GetEstateAgent(estateAgentId);
        }

        #region PropertyMethods
        public void SetName(string name)
        {
            if (activeEstateAgent.Name != name)
				activeEstateAgent.Name = name;
        }

        public void SetTelephone(string telephone)
        {
			if (activeEstateAgent.Telephone != telephone)
				activeEstateAgent.Telephone = telephone;
        }

        public void SetEmail(string email)
        {
			if (activeEstateAgent.Email != email)
				activeEstateAgent.Email = email;
        }

        public void SetStartingDate(DateTime startingDate)
        {
			if (activeEstateAgent.StartingDate != startingDate)
				activeEstateAgent.StartingDate = startingDate;
        }

        public void SetTerminationDate(DateTime startingDate)
        {
			if (activeEstateAgent.TerminationDate != startingDate)
				activeEstateAgent.TerminationDate = startingDate;
        }
        #endregion
        
		public List<EstateAgent> SearchEstateAgents(int id, string name, string telephone, string email)
		{
			return estateAgentCatalog.SearchEstateAgents(id, name, telephone, email);
        }

        #region Appointment

        public Appointment MakeNewAppointment(Case cCase, DateTime startTimeStamp, DateTime endTimeStamp, string description, string place, Customer customer)
        {
            return new Appointment(startTimeStamp, endTimeStamp, description, place, customer, cCase);
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
