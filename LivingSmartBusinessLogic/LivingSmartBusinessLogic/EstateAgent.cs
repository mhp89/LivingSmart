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

        public string Name { get { return _name; } internal set { _name = value; } }
        public string Telephone { get { return _telephone; } internal set { _telephone = value; } }
        public string Email { get { return _email; } internal set { _email = value; } }
        public DateTime StartingDate { get { return _startingDate; } internal set { _startingDate = value; } }
        public DateTime TerminationDate { get { return _terminationDate; } internal set { _terminationDate = value; } }

        #endregion

        #region Collections

        private List<Appointment> appointments;

        #endregion

        public EstateAgent()
        {
            
        }
        public EstateAgent(int id, string name, string telephone, string email, DateTime startingDate, DateTime terminationDate)
        {
            appointments = new List<Appointment>();
            this.id = id;
            _name = name;
            _telephone = telephone;
            _email = email;
            _startingDate = startingDate;
            _terminationDate = terminationDate;

        }

        #region Methods

        #endregion
    }
}
