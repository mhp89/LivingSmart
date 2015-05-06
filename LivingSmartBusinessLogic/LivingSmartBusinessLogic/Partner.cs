using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Partner
    {
        private int Id;

        #region Private Fields

        private int _Name;
        private int _Telephone;
        private int _Email;
        private int _City;
        private int _Timezone;

        #endregion

        #region Properties

        public int Name { get { return _Name; } set { _Name = value; } }
        public int Telephone { get { return _Telephone; } set { _Telephone = value; } }
        public int Email { get { return _Email; } set { _Email = value; } }
        public int City { get { return _City; } set { _City = value; } }
        public int Timezone { get { return _Timezone; } set { _Timezone = value; } }

        #endregion
    }
}
