using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Neighborhood
    {
        
        #region Private Fields

        private int _zipCode;
        private string _name;
        private int _value;

        #endregion

        #region Properties

        public int Id { get; private set; }
        public City City { get; private set; }
        public int ZipCode { get { return _zipCode; } internal set { _zipCode = value; } }
        public string Name { get { return _name; } internal set { _name = value; } }
        public int Value { get { return _value; } internal set { _value = value; } }

        #endregion

        internal Neighborhood(City city, string name, int value)
        {
            City = city;
            Name = name;
            Value = value;
        }
        internal Neighborhood(int id, City city, string name, int value)
        {
            Id = id;
            City = city;
            Name = name;
            Value = value;
        }

        internal Neighborhood(int id, int zipCode, string name, int value)
        {
            Id = id;
            ZipCode = zipCode;
            Name = name;
            Value = value;
        }

        #region Methods

        #endregion
    }
}
