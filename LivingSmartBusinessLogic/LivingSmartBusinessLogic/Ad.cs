using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Ad
    {
        public int Id { get; private set; }

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

        internal Ad(string type, DateTime startDate, DateTime endDate, int price)
        {
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }
        internal Ad(int id, string type, DateTime startDate, DateTime endDate, int price)
        {
            Id = id;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }

        #region Methods

        #endregion
    }
}
