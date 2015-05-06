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
        private Customer _customer;

        #endregion

        #region Properties

        public Case Case { get { return _case; } set { _case = value; } }
        public DateTime Timestamp { get { return _timestamp; } set { _timestamp = value; } }
        public int Duration { get { return _duration; } set { _duration = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Place { get { return _place; } set { _place = value; } }
        public Customer Customer { get { return _customer; } set { _customer = value; } }


        #endregion
    }
}
