using System;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Holds the information for an Ad
    /// </summary>
    /// <author>Mathias Poulsen</author>
    public class Ad
    {

        #region Private Fields

        private string _type;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _price;

        #endregion

        #region Properties

        public int Id { get; internal set; }

        public string Type
        {
            get { return _type; } 
            internal set { _type = value; }
        }
        public DateTime StartDate 
        { 
            get { return _startDate; } 
            internal set { _startDate = value; } 
        }

        public DateTime EndDate
        {
            get { return _endDate; } 
            internal set { _endDate = value; }
        }

        public int Price
        {
            get { return _price; } 
            internal set { _price = value; }
        }

        #endregion

        internal Ad(string type, DateTime startDate, DateTime endDate, int price)
		{
			Id = -1;
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
