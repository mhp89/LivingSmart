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

        public string Type { get { return _type; } internal set { _type = value; } }
        public DateTime StartDate { get { return _startDate; } internal set { _startDate = value; } }
        public DateTime EndDate { get { return _endDate; } internal set { _endDate = value; } }
        public int Price { get { return _price; } internal set { _price = value; } }

        #endregion

        #region Collections

        #endregion

        internal Ad()
        {
            
        }

        internal Ad(int id, string type, DateTime startDate, DateTime endDate, int price)
        {
            this.id = id;
            _type = type;
            _startDate = startDate;
            _endDate = endDate;
            _price = price;
        }

        #region Methods

        #endregion
    }
}
