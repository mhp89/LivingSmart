using System;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Holds the information for an EstateAgent
    /// </summary>
    public class EstateAgent
    {
        
        #region Private Fields

        private string _name;
        private string _telephone;
        private string _email;
        private DateTime _startingDate;
		private DateTime? _terminationDate;
		private string _username;
		private string _password;

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
			internal set { _terminationDate = value; }
		}
		public string Username { get { return _username; } internal set { _username = value; } }
		public string Password { get { return _password; } internal set { _password = value; } }

        #endregion

        internal EstateAgent(string name, string telephone, string email,
			DateTime startingDate, DateTime? terminationDate, string username, string password)
        {
	        Id = -1;
            Name = name;
            Telephone = telephone;
            Email = email;
            StartingDate = startingDate;
            TerminationDate = terminationDate;
            Username = username;
			Password = password;
        }
        internal EstateAgent(int id, string name, string telephone, string email, 
            DateTime startingDate, DateTime? terminationDate, string username, string password)
        {
            Id = id;
            Name = name;
            Telephone = telephone;
            Email = email;
            StartingDate = startingDate;
            TerminationDate = terminationDate;
	        Username = username;
	        Password = password;
        }

        #region Methods

        #endregion
    }
}
