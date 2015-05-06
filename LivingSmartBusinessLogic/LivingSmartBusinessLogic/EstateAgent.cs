using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class EstateAgent
    {
        private int Id;

        #region Private Fields

        private int _Name;
        private int _Telephone;
        private int _Email;
        private int _StartingDate;
        private int _TerminationDate;

        #endregion

        #region Properties

        public int Name { get { return _Name; } set { _Name = value; } }
        public int Telephone { get { return _Telephone; } set { _Telephone = value; } }
        public int Email { get { return _Email; } set { _Email = value; } }
        public int StartingDate { get { return _StartingDate; } set { _StartingDate = value; } }
        public int TerminationDate { get { return _TerminationDate; } set { _TerminationDate = value; } }

        #endregion

        #region Collections

        private List<Appointment> Appointments;

        #endregion
    }
}
