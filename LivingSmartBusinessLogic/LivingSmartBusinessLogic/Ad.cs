using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Ad
    {
        private int id;

        #region Private Fields

        private string _type;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _price;

        #endregion

        #region Properties

        public string Type { get { return _type; } set { _type = value; } }
        public DateTime StartDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime EndDate { get { return _endDate; } set { _endDate = value; } }
        public int Price { get { return _price; } set { _price = value; } }

        #endregion

        #region Collections

        #endregion

        #region Methods

        #endregion
    }
}
