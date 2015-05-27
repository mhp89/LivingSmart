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
        private DateTime _timestamp;
        private int _duration;
        private string _description;
        private string _place;
        private Customer _customer;

        #endregion

        #region Properties

        public Case Case { get { return _case; } internal set { _case = value; } }
        public DateTime Timestamp { get { return _timestamp; } internal set { _timestamp = value; } }
        public int Duration { get { return _duration; } internal set { _duration = value; } }
        public string Description { get { return _description; } internal set { _description = value; } }
        public string Place { get { return _place; } internal set { _place = value; } }
        public Customer Customer { get { return _customer; } internal set { _customer = value; } }


        #endregion

        internal Appointment()
        {
            
        }

        internal Appointment(int id, Case cCase, DateTime timeStamp, int duration, string description, string place, Customer customer)
        {
            Id = id;
            Case = cCase;
            Timestamp = timeStamp;
            Duration = duration;
            Description = description;
            Place = place;
            Customer = customer;
        }

        #region Methods

        #endregion
    }
}
