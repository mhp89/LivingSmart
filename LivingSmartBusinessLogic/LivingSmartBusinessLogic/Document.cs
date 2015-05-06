using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Document
    {
        private int id;

        #region Private Fields

        private string _type;
        private int _price;
        private string _location;
        private string _status;

        #endregion

        #region Properties

        public string Type { get { return _type; } set { _type = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Status { get { return _status; } set { _status = value; } }

        #endregion
    }
}
