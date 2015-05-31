using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Statistics
    {
        public int Id { get; internal set; }

        #region Private Fields

        private int _year;
        private string _month;
        private string _estateAgentName;
        private int _sellingpriceTotal;
        private int _propertiesTotal;

        #endregion

        #region Properties

        public int Year { get { return _year; } internal set { _year = value; } }
        public string Month { get { return _month; } internal set { _month = value; } }
        public string EstateAgentName { get { return _estateAgentName; } internal set { _estateAgentName = value; } }
        public int SellingpriceTotal { get { return _sellingpriceTotal; } internal set { _sellingpriceTotal = value; } }
        public int PropertiesTotal { get { return _propertiesTotal; } internal set { _propertiesTotal = value; } }

        #endregion

        internal Statistics()
        {
        }
        internal Statistics(int year, string month, string name, int total, int count)
        {
            Year = year;
            Month = month;
            EstateAgentName = name;
            SellingpriceTotal = total;
            PropertiesTotal = count;
        }
        internal Statistics(int year, string month, int total, int count)
        {
            Year = year;
            Month = month;
            SellingpriceTotal = total;
            PropertiesTotal = count;
        }
        internal Statistics(int year, int total, int count)
        {
            Year = year;
            SellingpriceTotal = total;
            PropertiesTotal = count;
        }

        #region Methods

        #endregion
    }
}
