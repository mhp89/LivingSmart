using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class AskingPrice
    {
        private int Id;

        #region Private Fields

        private int _Value;
        private int _Date;

        #endregion

        #region Properties

        public int Value { get { return _Value; } set { _Value = value; } }
        public int Date { get { return _Date; } set { _Date = value; } }

        #endregion
    }
}
