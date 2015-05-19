using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Neighborhood
    {
        private City city;

        #region Private Fields

        private string _name;
        private int _value;

        #endregion

        #region Properties

        public string Name { get { return _name; } set { _name = value; } }
        public int Value { get { return _value; } set { _value = value; } }

        #endregion

        public Neighborhood(City city, string name, int value)
        {
            this.city = city;
            _name = name;
            _value = value;
        }

        #region Methods

        #endregion
    }
}
