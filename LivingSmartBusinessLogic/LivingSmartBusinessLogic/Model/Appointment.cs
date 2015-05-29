using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Appointment
    {
        
        #region Private Fields

        private int _caseId;
        private DateTime _startTimeStamp;
        private DateTime _endTimeStamp;
        private string _description;
        private string _place;
        private int _customerId;

        #endregion

        #region Properties

        public int Id { get; private set; }
        public int CaseId { get { return _caseId; } internal set { _caseId = value; } }
        public DateTime StartTimestamp { get { return _startTimeStamp; } 
            internal set { _startTimeStamp = value; } }
        public DateTime EndTimeStamp { get { return _endTimeStamp; } 
            internal set { _startTimeStamp = value; } }
        public string Description { get { return _description; } 
            internal set { _description = value; } }
        public string Place { get { return _place; } internal set { _place = value; } }
        public int CustomerId { get { return _customerId; } 
            internal set { _customerId = value; } }


        #endregion

        internal Appointment(int caseId, DateTime startTimeStamp, DateTime endTimeStamp, 
            string description, string place, int customerId)
        {
            CaseId = caseId;
            StartTimestamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            Description = description;
            Place = place;
            CustomerId = customerId;
        }

        internal Appointment(int id, int caseId, DateTime startTimeStamp, 
            DateTime endTimeStamp, string description, string place, int customerId)
        {
            Id = id;
            CaseId = caseId;
            StartTimestamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            Description = description;
            Place = place;
            CustomerId = customerId;
        }

        #region Methods

        #endregion
    }
}
