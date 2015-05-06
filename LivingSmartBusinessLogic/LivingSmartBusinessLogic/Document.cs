using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Document
    {
        private int Id;

        #region Private Fields

        private int _Type;
        private int _Price;
        private int _Location;
        private int _Status;

        #endregion

        #region Properties

        public int Type { get { return _Type; } set { _Type = value; } }
        public int Price { get { return _Price; } set { _Price = value; } }
        public int Location { get { return _Location; } set { _Location = value; } }
        public int Status { get { return _Status; } set { _Status = value; } }

        #endregion
    }
}
