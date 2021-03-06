using System;
using LivingSmartBusinessLogic.Controller;

namespace LivingSmartBusinessLogic.Entity
{
    /// <summary>
    /// Hold the information for a Rating
    /// </summary>
    /// <author>Mathias Pousen</author>
    public class Rating
    {

        #region Private Fields

        private long? _estateAgentValue;
        private long _systemValue;
        private DateTime _date;

        #endregion

        #region Properties

        public int Id
        {
            get; 
            internal set;
        }
        public long? EstateAgentValue 
        { 
            get { return _estateAgentValue; } 
            internal set { _estateAgentValue = value; } 
        }
        public long SystemValue 
        { 
            get { return _systemValue; } 
            internal set { _systemValue = value; } 
        }

        public DateTime Date
        {
            get { return _date; } 
            internal set { _date = value; }
        }
        public EstateAgent EstateAgent { get; private set; }

        #endregion

        internal Rating(long systemValue, long? estateAgentValue, int estateAgentId)
		{
			Id = -1;
			EstateAgentValue = estateAgentValue;
            SystemValue = systemValue;
            Date = DateTime.Now;
			EstateAgent = EstateAgentController.Instance.GetEstateAgent(estateAgentId);
		}

        internal Rating(int id, long? estateAgentValue, long systemValue, DateTime date, 
            int estateAgentId)
        {
            Id = id;
            EstateAgentValue = estateAgentValue;
            SystemValue = systemValue;
            Date = date;
            EstateAgent = EstateAgentController.Instance.GetEstateAgent(estateAgentId);
        }

        #region Methods

        #endregion
    }
}
