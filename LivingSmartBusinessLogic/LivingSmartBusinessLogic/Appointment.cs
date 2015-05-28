using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Appointment
    {
        public int Id { get; private set; }
        
        #region Private Fields

        private Case _case;
        private DateTime _startTimeStamp;
        private DateTime _endTimeStamp;
        private string _description;
        private string _place;
        private Customer _customer;

        #endregion

        #region Properties

        public Case Case { get { return _case; } internal set { _case = value; } }
        public DateTime StartTimeStamp { get { return _startTimeStamp; } internal set { _startTimeStamp = value; } }
        public DateTime EndTimeStamp { get { return _endTimeStamp; } internal set { _endTimeStamp = value; } }
        public string Description { get { return _description; } internal set { _description = value; } }
        public string Place { get { return _place; } internal set { _place = value; } }
        public Customer Customer { get { return _customer; } internal set { _customer = value; } }


        #endregion

        internal Appointment(Case cCase, DateTime startTimeStamp, DateTime endTimeStamp, string description, string place, Customer customer)
        {
            Case = cCase;
            StartTimeStamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            Description = description;
            Place = place;
            Customer = customer;
        }
        internal Appointment(int id, Case cCase, DateTime startTimeStamp, DateTime endTimeStamp, string description, string place, Customer customer)
        {
            Id = id;
            Case = cCase;
            StartTimeStamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            Description = description;
            Place = place;
            Customer = customer;
        }

        #region Methods

        #endregion
    }
}
