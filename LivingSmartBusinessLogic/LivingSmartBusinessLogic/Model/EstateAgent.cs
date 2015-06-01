using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgent
    {
        
        #region Private Fields

        private string _name;
        private string _telephone;
        private string _email;
        private DateTime _startingDate;
        private DateTime? _terminationDate;

        #endregion

        #region Properties
        public int Id { get; internal set; }
        public string Name { get { return _name; } internal set { _name = value; } }
        public string Telephone { get { return _telephone; } 
            internal set { _telephone = value; } }
        public string Email { get { return _email; } internal set { _email = value; } }
        public DateTime StartingDate { get { return _startingDate; } 
            internal set { _startingDate = value; } }
        public DateTime? TerminationDate { get { return _terminationDate; } 
            internal set { _terminationDate = value; } }

        #endregion

        internal EstateAgent(string name, string telephone, string email, 
            DateTime startingDate)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
            StartingDate = startingDate;
            TerminationDate = null;
        }
        internal EstateAgent(int id, string name, string telephone, string email, 
            DateTime startingDate, DateTime? terminationDate)
        {
            Id = id;
            Name = name;
            Telephone = telephone;
            Email = email;
            StartingDate = startingDate;
            TerminationDate = terminationDate;
        }

        #region Methods

        #endregion
    }
}
