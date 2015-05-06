using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Ad
    {
        private int Id;

        #region Private Fields
        
        private int _Type;
        private int _StartDate;
        private int _EndDate;
        private int _Price;

        #endregion

        #region Properties

        public int Type { get { return _Type; } set { _Type = value; } }
        public int StartDate { get { return _StartDate; } set { _StartDate = value; } }
        public int EndDate { get { return _EndDate; } set { _EndDate = value; } }
        public int Price { get { return _Price; } set { _Price = value; } }

        #endregion

        #region Collections

        #endregion
    }
}
