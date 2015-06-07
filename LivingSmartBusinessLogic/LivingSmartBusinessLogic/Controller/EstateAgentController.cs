using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
    /// <summary>
    /// Estateagent controller
    /// </summary>
    /// <author>Mathias Pousen</author>
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
        /// <summary>
        /// Tilf�jer en m�gler til kataloget
        /// </summary>
        /// <param name="estateAgent"></param>
        private void AddEstateAgent(EstateAgent estateAgent)
        {
            estateAgentCatalog.AddToCatalog(estateAgent);
        }
        /// <summary>
        /// Laver en ny m�gler samt s�tter den nye m�gler som aktiv m�gler
        /// </summary>
        /// <param name="name"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <param name="startingDate"></param>
        /// <param name="terminationDate"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <author>Ren� S�rensen</author>
		public EstateAgent MakeNewEstateAgent(string name, string telephone, string email, DateTime startingDate, DateTime? terminationDate, string username, string password)
        {
            SetActiveEstateAgent(new EstateAgent(name, telephone, email, startingDate, terminationDate, username, password));
            return ActiveEstateAgent;
        }
        /// <summary>
        /// Henter en given m�gler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public EstateAgent ReadEstateAgent(int id)
        {
			return estateAgentCatalog.Read(id);
        }
        /// <summary>
        /// Henter alle m�glere fra kataloget
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
		public ReadOnlyCollection<EstateAgent> GetEstateAgents()
		{
			return estateAgentCatalog.GetEstateAgents();
		}
        /// <summary>
        /// Henter en given m�gler
        /// </summary>
        /// <param name="estateAgentId"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public EstateAgent GetEstateAgent(int estateAgentId)
        {
            return estateAgentCatalog.GetEstateAgent(estateAgentId);
        }

        #region PropertyMethods
        /// <summary>
        /// S�tter navn p� den aktive m�gler
        /// </summary>
        /// <param name="name"></param>
        /// <author>Mathias Poulsen</author>
        public void SetName(string name)
        {
            if (ActiveEstateAgent.Name != name)
				ActiveEstateAgent.Name = name;
        }
        /// <summary>
        /// S�tter telefonnummer p� den aktive m�gler
        /// </summary>
        /// <param name="telephone"></param>
        /// <author>Mathias Poulsen</author>
        public void SetTelephone(string telephone)
        {
			if (ActiveEstateAgent.Telephone != telephone)
				ActiveEstateAgent.Telephone = telephone;
        }
        /// <summary>
        /// S�tter email p� den aktive m�gler
        /// </summary>
        /// <param name="email"></param>
        /// <author>Mathias Poulsen</author>
        public void SetEmail(string email)
        {
			if (ActiveEstateAgent.Email != email)
				ActiveEstateAgent.Email = email;
        }
        /// <summary>
        /// S�tter startdato p� den aktive m�gler
        /// </summary>
        /// <param name="startingDate"></param>
        /// <author>Mathias Poulsen</author>
        public void SetStartingDate(DateTime startingDate)
        {
			if (ActiveEstateAgent.StartingDate != startingDate)
				ActiveEstateAgent.StartingDate = startingDate;
        }
        /// <summary>
        /// S�tter oph�rsdato p� den aktive m�gler
        /// </summary>
        /// <param name="terminationDate"></param>
        /// <author>Mathias Poulsen</author>
        public void SetTerminationDate(DateTime? terminationDate)
        {
			if (ActiveEstateAgent.TerminationDate != terminationDate)
				ActiveEstateAgent.TerminationDate = terminationDate;
        }
        #endregion
        
		public List<EstateAgent> SearchEstateAgents(int id, string name, string telephone, string email)
		{
			return estateAgentCatalog.SearchEstateAgents(id, name, telephone, email);
        }

        #region Appointment

        /// <summary>
        /// Laver og returnerer ny aftale
        /// </summary>
        /// <param name="cCase"></param>
        /// <param name="startTimeStamp"></param>
        /// <param name="endTimeStamp"></param>
        /// <param name="description"></param>
        /// <param name="place"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public Appointment MakeNewAppointment(Case cCase, DateTime startTimeStamp, DateTime endTimeStamp, string description, string place, Customer customer)
        {
            return new Appointment(startTimeStamp, endTimeStamp, description, place, customer, cCase);
        }
        /// <summary>
        /// Tilf�jer aftale til aftalekataloget
        /// </summary>
        /// <param name="appointment"></param>
        /// <author>Mathias Poulsen</author>
        public void AddAppointment(Appointment appointment)
        {
            appointmentCatalog.AddToCatalog(ActiveEstateAgent.Id, appointment);
        }
        /// <summary>
        /// Fjerner aftale fra aftalekataloget
        /// </summary>
        /// <param name="appointment"></param>
        /// <author>Mathias Poulsen</author>
        public void RemoveAppointmentFromEstateAgent(Appointment appointment)
        {
            appointmentCatalog.RemoveFromCatalog(ActiveEstateAgent.Id, appointment);
        }
        /// <summary>
        /// Henter alle aftaler
        /// </summary>
        /// <param name="appointment"></param>
        /// <author>Mathias Poulsen</author>
        public void GetAppointments(Appointment appointment)
        {
            appointmentCatalog.GetAppointments(ActiveEstateAgent.Id);
        }
        /// <summary>
        /// Opdaterer/gemmer en given aftale
        /// </summary>
        /// <param name="appointment"></param>
        /// <param name="estateAgentId"></param>
        /// <author>Mathias Poulsen</author>
        public void UpdateAppointment(Appointment appointment, int estateAgentId)
        {
            appointmentCatalog.Save(appointment, estateAgentId);
        }
        /// <summary>
        /// L�ser en given aftale
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
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


        /// <summary>
        /// Henter logindata
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
		public EstateAgent LoginEstateAgent(string username, string password)
	    {
			return estateAgentCatalog.LoginEstateAgent(username, password);
	    }
        /// <summary>
        /// Tjekker om brugernavn allerede er i brug
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public bool IsUsernameAvailable(string username)
        {
            return estateAgentCatalog.IsUsernameAvailable(username);
        }
	}
}
