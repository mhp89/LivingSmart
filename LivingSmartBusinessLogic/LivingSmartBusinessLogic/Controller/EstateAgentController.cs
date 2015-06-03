using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

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

        public EstateAgent ActiveEstateAgent { get; private set; }

        private EstateAgentController()
        {
            estateAgentCatalog = new EstateAgentCatalog();
            appointmentCatalog = new AppointmentCatalog();
        }

        #region Methods

        #region AdminActiveEstateAgent
        public void SetActiveEstateAgent(EstateAgent activEstateAgent)
        {
            this.ActiveEstateAgent = activEstateAgent;
        }

        public void CancelActiveEstateAgent()
        {
            ActiveEstateAgent = null;
        }

		public void SaveActiveEstateAgent()
		{
			estateAgentCatalog.Save(ActiveEstateAgent);
			if (ActiveEstateAgent.Id != -1)
				AddEstateAgent(ActiveEstateAgent);
        }
        #endregion

        private void AddEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.AddToCatalog(estateAgent);
        }

		public EstateAgent MakeNewEstateAgent(string name, string telephone, string email, DateTime startingDate, string username, string password)
        {
            SetActiveEstateAgent(new EstateAgent(name, telephone, email, startingDate, username, password));
            return ActiveEstateAgent;
        }

        public EstateAgent ReadEstateAgent(int id)
        {
			return estateAgentCatalog.Read(id);
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
            if (ActiveEstateAgent.Name != name)
				ActiveEstateAgent.Name = name;
        }

        public void SetTelephone(string telephone)
        {
			if (ActiveEstateAgent.Telephone != telephone)
				ActiveEstateAgent.Telephone = telephone;
        }

        public void SetEmail(string email)
        {
			if (ActiveEstateAgent.Email != email)
				ActiveEstateAgent.Email = email;
        }

        public void SetStartingDate(DateTime startingDate)
        {
			if (ActiveEstateAgent.StartingDate != startingDate)
				ActiveEstateAgent.StartingDate = startingDate;
        }

        public void SetTerminationDate(DateTime startingDate)
        {
			if (ActiveEstateAgent.TerminationDate != startingDate)
				ActiveEstateAgent.TerminationDate = startingDate;
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
            appointmentCatalog.AddToCatalog(ActiveEstateAgent.Id, appointment);
        }

        public void RemoveAppointmentFromEstateAgent(Appointment appointment)
        {
            appointmentCatalog.RemoveFromCatalog(ActiveEstateAgent.Id, appointment);
        }

        public void GetAppointments(Appointment appointment)
        {
            appointmentCatalog.GetAppointments(ActiveEstateAgent.Id);
        }

        public void UpdateAppointment(Appointment appointment, int estateAgentId)
        {
            appointmentCatalog.Save(appointment, estateAgentId);
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

		public EstateAgent LoginEstateAgent(string username, string password)
	    {
			return estateAgentCatalog.LoginEstateAgent(username, password);
	    }

        public bool IsUsernameAvailable(string username)
        {
            return estateAgentCatalog.IsUsernameAvailable(username);
        }
	}
}
