using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Appointment
    {
        private int id;
        
        #region Private Fields

        private Case _case;
        private DateTime _timestamp;
        private int _duration;
        private string _description;
        private string _place;
        private Customer _potBuyer;

        #endregion

        #region Properties

        public Case Case { get { return _case; } set { _case = value; } }
        public DateTime Timestamp { get { return _timestamp; } set { _timestamp = value; } }
        public int Duration { get { return _duration; } set { _duration = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Place { get { return _place; } set { _place = value; } }
        public Customer Customer { get { return _potBuyer; } set { _potBuyer = value; } }


        #endregion

        public Appointment()
        {
            
        }

        public Appointment(int id, Case cCase, DateTime timeStamp, int duration, string description, string place, Customer potBuyer)
        {
            this.id = id;
            _case = cCase;
            _timestamp = timeStamp;
            _duration = duration;
            _description = description;
            _place = place;
            _potBuyer = potBuyer;
        }

        #region Methods

        #endregion
    }
}
