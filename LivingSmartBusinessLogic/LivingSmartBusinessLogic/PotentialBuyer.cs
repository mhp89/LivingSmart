using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PotentialBuyer
    {
        public Customer PotBuyer { get; private set; }
        public Case NewCase { get; private set; }

        #region Private Fields

        private DateTime _date;

        #endregion

        #region Properties

        public DateTime Date { get { return _date; } internal set { _date = value; } }

        #endregion

        internal PotentialBuyer(Customer potBuyer)
        {
            PotBuyer = potBuyer;
        }

        #region Methods

        #endregion
    }
}
