using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Neighborhood
    {
        // are we using this?
        // private City city;

        #region Private Fields

        private int _zipCode;
        private string _name;
        private int _value;

        #endregion

        #region Properties

        public int ZipCode { get { return _zipCode; } internal set { _zipCode = value; } }
        public string Name { get { return _name; } internal set { _name = value; } }
        public int Value { get { return _value; } internal set { _value = value; } }

        #endregion

        internal Neighborhood(int zipCode, string name, int value)
        {
            _zipCode = zipCode;
            _name = name;
            _value = value;
        }

        #region Methods

        #endregion
    }
}
