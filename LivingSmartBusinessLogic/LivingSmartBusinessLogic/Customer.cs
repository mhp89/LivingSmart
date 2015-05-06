using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Customer
    {
        private int id;

        #region Private Fields

        private string _name;
        private DateTime _dateOfBirth;
        private string _address;
        private int _zipCode;
        private string _email;
        private string _telephone;

        #endregion

        #region Properties

        public string Name { get { return _name; } set { _name = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public int ZipCode { get { return _zipCode; } set { _zipCode = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Telephone { get { return _telephone; } set { _telephone = value; } }


        #endregion
    }
}
