using System;
using LivingSmartBusinessLogic.Controller;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Holds the information for a Appointment.
    /// </summary>
    /// <author>Mathias Poulsen</author>
    public class Appointment
    {
        
        #region Private Fields

        private int _caseId;
        private DateTime _startTimeStamp;
        private DateTime _endTimeStamp;
        private string _description;
        private string _place;
        private int _customerId;

        #endregion

        #region Properties

        public int Id
        {
            get; 
            internal set;
        }
        public DateTime StartTimestamp 
        { 
            get { return _startTimeStamp; } 
            internal set { _startTimeStamp = value; } 
        }
        public DateTime EndTimeStamp 
        { 
            get { return _endTimeStamp; } 
            internal set { _startTimeStamp = value; } 
        }
        public string Description 
        { 
            get { return _description; } 
            internal set { _description = value; } 
        }

        public string Place
        {
            get { return _place; } 
            internal set { _place = value; }
        }

        public Customer Customer
        {
            get;
            private set;
        }

        public Case Case
        {
            get;
            private set;
        }

        #endregion

        internal Appointment(DateTime startTimeStamp, DateTime endTimeStamp, 
            string description, string place, Customer customer, Case cCase)
        {
            StartTimestamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            Description = description;
            Place = place;
            Customer = customer;
            Case = cCase;
        }

        internal Appointment(int id, int caseId, DateTime startTimeStamp, 
            DateTime endTimeStamp, string description, string place, int customerId)
        {
            Id = id;
            StartTimestamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            Description = description;
            Place = place;

            Case = CaseController.Instance.GetCase(caseId);
            Customer = CustomerController.Instance.GetCustomer(customerId);
        }

        #region Methods

        #endregion
    }
}
