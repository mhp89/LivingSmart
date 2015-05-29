using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LivingSmartBusinessLogic.Controller;

namespace LivingSmartBusinessLogic
{
    public class Customer
    {

        #region Private Fields

        private string _name;
        private DateTime _dateOfBirth;
        private string _address;
        private City _city;
        private string _email;
        private string _telephone;

        #endregion

        #region Properties

        public int Id { get; internal set; }
        public string Name { get { return _name; } internal set { _name = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } 
            internal set { _dateOfBirth = value; } }
        public string Address { get { return _address; } internal set { _address = value; } }
        public City City { get { return _city; } internal set { _city = value; } }
        public string Email { get { return _email; } internal set { _email = value; } }
        public string Telephone { get { return _telephone; } 
            internal set { _telephone = value; } }


        #endregion

        internal Customer(string name, DateTime dateOfBirth, string address, 
            int zipCode, string email, string telephone)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            City = CityController.Instance.GetCity(zipCode);
            Email = email;
            Telephone = telephone;
        }
        internal Customer(int id, string name, DateTime dateOfBirth, string address, 
            int zipCode, string email, string telephone)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            City = CityController.Instance.GetCity(zipCode);
            Email = email;
            Telephone = telephone;
        }

        #region Methods

        #endregion
    }
}
