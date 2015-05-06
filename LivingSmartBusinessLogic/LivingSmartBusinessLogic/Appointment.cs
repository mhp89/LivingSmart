using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Appointment
    {
        private int Id;
        
        #region Private Fields

        private Case _Case;
        private int _Timestamp;
        private int _Duration;
        private int _Description;
        private int _Place;
        private Customer _Customer;

        #endregion

        #region Properties

        public Case Case { get { return _Case; } set { _Case = value; } }
        public int Timestamp { get { return _Timestamp; } set { _Timestamp = value; } }
        public int Duration { get { return _Duration; } set { _Duration = value; } }
        public int Description { get { return _Description; } set { _Description = value; } }
        public int Place { get { return _Place; } set { _Place = value; } }
        public Customer Customer { get { return _Customer; } set { _Customer = value; } }


        #endregion
    }
}
