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
        private long _systemValue;
        private DateTime _date;

        public Rating(Case cCase)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Properties

        public long EstateAgentValue { get { return _estateAgentValue; } internal set { _estateAgentValue = value; } }
        public long SystemValue { get { return _systemValue; } internal set { _systemValue = value; } }
        public DateTime Date { get { return _date; } internal set { _date = value; } }

        #endregion

        internal Rating(int id, long estateAgentValue, long systemValue, DateTime date)
        {
            this.id = id;
            _estateAgentValue = estateAgentValue;
            _systemValue = systemValue;
            _date = date;
        }

        #region Methods

        #endregion
    }
}
