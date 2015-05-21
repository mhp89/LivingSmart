using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Neighborhood
    {

        public int Id { get; private set; }
        public City city { get; private set; }

        #region Private Fields

        private string _name;
        private int _value;

        #endregion

        #region Properties

        public string Name { get { return _name; } internal set { _name = value; } }
        public int Value { get { return _value; } internal set { _value = value; } }

        #endregion

        internal Neighborhood(City city, string name, int value)
        {
            this.city = city;
            _name = name;
            _value = value;
        }

        #region Methods

        #endregion
    }
}
