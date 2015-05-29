using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class City
    {
        #region Private Fields

        private int _zipcode;
        private string _district;

        #endregion

        #region Properties

        public int ZipCode { get { return _zipcode; } internal set { _zipcode = value; } }
		public string District { get { return _district; } internal set { _district = value; } }

        #endregion

        internal City(int zipCode, string district)
        {
            ZipCode = zipCode;
            District = district;
        }

        #region Methods

        #endregion
    }
}
