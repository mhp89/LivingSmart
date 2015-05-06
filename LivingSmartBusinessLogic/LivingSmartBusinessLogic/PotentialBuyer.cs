using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PotentialBuyer
    {
        private Customer PotBuyer;

        #region Private Fields

        private int _Date;

        #endregion

        #region Properties

        public int Date { get { return _Date; } set { _Date = value; } }

        #endregion
    }
}
