using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class City
    {
        private int zipCode;
        private string district;

        #region Private Fields



        #endregion

        #region Properties

		public int ZipCode { get; private set; }


        #endregion

        internal City(int zipCode, string district)
        {
            this.zipCode = zipCode;
            this.district = district;
        }

        #region Methods

        #endregion
    }
}
