﻿using System;
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
            Name = name;
            Value = value;
        }

        #region Methods

        #endregion
    }
}