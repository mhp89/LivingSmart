using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Appointment
    {
        public int Id { get; private set; }
        
        #region Private Fields

        private int _caseId;
        private DateTime _timestamp;
        private int _duration;
        private string _description;
        private string _place;
        private int _customerId;

        #endregion

        #region Properties

        public int CaseId { get { return _caseId; } internal set { _caseId = value; } }
        public DateTime Timestamp { get { return _timestamp; } internal set { _timestamp = value; } }
        public int Duration { get { return _duration; } internal set { _duration = value; } }
        public string Description { get { return _description; } internal set { _description = value; } }
        public string Place { get { return _place; } internal set { _place = value; } }
        public int CustomerId { get { return _customerId; } internal set { _customerId = value; } }


        #endregion

        internal Appointment()
        {
            
        }

        internal Appointment(int id, int caseId, DateTime timeStamp, int duration, string description, string place, int customerId)
        {
            Id = id;
            _caseId = caseId;
            _timestamp = timeStamp;
            _duration = duration;
            _description = description;
            _place = place;
            _customerId = customerId;
        }

        #region Methods

        #endregion
    }
}
