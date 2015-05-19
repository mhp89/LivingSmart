using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class AskingPrice
    {
        private int id;

        #region Private Fields

        private long _value;
        private DateTime _date;

        #endregion

        #region Properties

        public long Value { get { return _value; } internal set { _value = value; } }
        public DateTime Date { get { return _date; } internal set { _date = value; } }

        #endregion

        public AskingPrice()
        {
            
        }

        public AskingPrice(int id, long value, DateTime date)
        {
            this.id = id;
            _value = value;
            _date = date;
        }

        #region Methods

        #endregion
    }
}
