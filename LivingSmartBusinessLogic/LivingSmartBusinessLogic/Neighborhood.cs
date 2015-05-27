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

        public string Name { get { return _name; } internal set { _name = value; } }
        public int Value { get { return _value; } internal set { _value = value; } }

        #endregion

        internal Neighborhood(City city, string name, int value)
        {
            this.city = city;
            _name = name;
            _value = value; //gennemsnitlig m2 pris af boligen for det område
        }

        #region Methods

        #endregion
    }
}
