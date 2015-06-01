using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    /// <summary>
    /// Klasse til statistik der indlæses fra databasen
    /// </summary>
    /// <author>Maja Olesen</author>
    public class Statistics
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; internal set; }

        #region Private Fields

        private int _year;
        private string _month;
        private string _estateAgentName;
        private int _sellingpriceTotal;
        private int _propertiesTotal;

        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public int Year { get { return _year; } internal set { _year = value; } }
        /// <summary>
        /// 
        /// </summary>
        public string Month { get { return _month; } internal set { _month = value; } }
        /// <summary>
        /// 
        /// </summary>
        public string EstateAgentName { get { return _estateAgentName; } internal set { _estateAgentName = value; } }
        /// <summary>
        /// 
        /// </summary>
        public int SellingpriceTotal { get { return _sellingpriceTotal; } internal set { _sellingpriceTotal = value; } }
        /// <summary>
        /// 
        /// </summary>
        public int PropertiesTotal { get { return _propertiesTotal; } internal set { _propertiesTotal = value; } }

        #endregion

        /// <summary>
        /// Tom constructor
        /// </summary>
        internal Statistics()
        {
        }
        /// <summary>
        /// Constructor der tager alle 5 parametre til Statistics klassen
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="name"></param>
        /// <param name="total"></param>
        /// <param name="count"></param>
        internal Statistics(int year, string month, string name, int total, int count)
        {
            Year = year;
            Month = month;
            EstateAgentName = name;
            SellingpriceTotal = total;
            PropertiesTotal = count;
        }
        /// <summary>
        /// Contructor der tager 4/5 parametre til Statistics klassen
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="total"></param>
        /// <param name="count"></param>
        internal Statistics(int year, string month, int total, int count)
        {
            Year = year;
            Month = month;
            SellingpriceTotal = total;
            PropertiesTotal = count;
        }
        
        #region Methods

        #endregion
    }
}
