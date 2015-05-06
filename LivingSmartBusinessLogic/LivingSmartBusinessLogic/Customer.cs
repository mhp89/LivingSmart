using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Customer
    {
        private int Id;

        #region Private Fields

        private int _Name;
        private int _DateOfBirth;
        private int _Address;
        private int _ZipCode;
        private int _Email;
        private int _Telephone;

        #endregion

        #region Properties

        public int Name { get { return _Name; } set { _Name = value; } }
        public int DateOfBirth { get { return _DateOfBirth; } set { _DateOfBirth = value; } }
        public int Address { get { return _Address; } set { _Address = value; } }
        public int ZipCode { get { return _ZipCode; } set { _ZipCode = value; } }
        public int Email { get { return _Email; } set { _Email = value; } }
        public int Telephone { get { return _Telephone; } set { _Telephone = value; } }


        #endregion
    }
}
