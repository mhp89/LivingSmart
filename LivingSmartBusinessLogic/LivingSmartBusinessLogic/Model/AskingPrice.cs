using System;

namespace LivingSmartBusinessLogic.Model
{
    public class AskingPrice
    {

        #region Private Fields

        private long _value;
        private DateTime _date;

        #endregion

        #region Properties

        public int Id { get; private set; }
        public long Value { get { return _value; } internal set { _value = value; } }
        public DateTime Date { get { return _date; } internal set { _date = value; } }

        #endregion

        internal AskingPrice(long value, DateTime date)
        {
            Value = value;
            Date = date;
        }
        internal AskingPrice(int id, long value, DateTime date)
        {
            Id = id;
            Value = value;
            Date = date;
        }

        #region Methods

        #endregion
    }
}
