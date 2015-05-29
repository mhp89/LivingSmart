using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class City
    {

        #region Private Fields



        #endregion

        #region Properties

		public int ZipCode { get; private set; }
        public string District { get; private set; }

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
