using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Customer
    {
        public int Id { get; private set; }

        #region Private Fields

        private string _name;
        private DateTime _dateOfBirth;
        private string _address;
        private City _city;
        private string _email;
        private string _telephone;

        #endregion

        #region Properties

        public string Name { get { return _name; } internal set { _name = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } internal set { _dateOfBirth = value; } }
        public string Address { get { return _address; } internal set { _address = value; } }
        public City City { get { return _city; } internal set { _city = value; } }
        public string Email { get { return _email; } internal set { _email = value; } }
        public string Telephone { get { return _telephone; } internal set { _telephone = value; } }


        #endregion

        internal Customer()
        {
            
        }

        internal Customer(int id, string name, DateTime dateOfBirth, string address, City city, string email, string telephone)
        {
            Id = id;
            _name = name;
            _dateOfBirth = dateOfBirth;
            _address = address;
            _city = city;
            _email = email;
            _telephone = telephone;
        }

        #region Methods

        #endregion
    }
}
