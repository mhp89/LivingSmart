using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Rating
    {
        private int id;

        #region Private Fields

        private long _estateAgentValue;
        private long _eystemValue;
        private DateTime _date;

        #endregion

        #region Properties

        public long EstateAgentValue { get { return _estateAgentValue; } set { _estateAgentValue = value; } }
        public long SystemValue { get { return _eystemValue; } set { _eystemValue = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }

        #endregion
    }
}
