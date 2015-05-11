using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgent
    {
        private int id;

        #region Private Fields

        private string _name;
        private string _telephone;
        private string _email;
        private DateTime _startingDate;
        private DateTime _terminationDate;

        #endregion

        #region Properties

        public string Name { get { return _name; } set { _name = value; } }
        public string Telephone { get { return _telephone; } set { _telephone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public DateTime StartingDate { get { return _startingDate; } set { _startingDate = value; } }
        public DateTime TerminationDate { get { return _terminationDate; } set { _terminationDate = value; } }

        #endregion

        #region Collections

        private List<Appointment> Appointments;

        #endregion

        #region Methods

        #endregion
    }
}
