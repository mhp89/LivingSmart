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
        private DateTime _startTimeStamp;
        private DateTime _endTimeStamp;
        private string _description;
        private string _place;
        private int _customerId;

        #endregion

        #region Properties

        public int CaseId { get { return _caseId; } internal set { _caseId = value; } }
        public DateTime StartTimestamp { get { return _startTimeStamp; } internal set { _startTimeStamp = value; } }
        public DateTime EndTimeStamp { get { return _endTimeStamp; } internal set { _startTimeStamp = value; } }
        public string Description { get { return _description; } internal set { _description = value; } }
        public string Place { get { return _place; } internal set { _place = value; } }
        public int CustomerId { get { return _customerId; } internal set { _customerId = value; } }


        #endregion

        internal Appointment()
        {
            
        }

        internal Appointment(int id, int caseId, DateTime startTimeStamp, DateTime endTimeStamp, string description, string place, int customerId)
        {
            Id = id;
            _caseId = caseId;
            _startTimeStamp = startTimeStamp;
            _endTimeStamp = endTimeStamp;
            _description = description;
            _place = place;
            _customerId = customerId;
        }

        #region Methods

        #endregion
    }
}
