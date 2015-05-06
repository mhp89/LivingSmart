using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Neighborhood
    {
        private City City;

        #region Private Fields

        private string _Name;
        private int _Value;

        #endregion

        #region Properties

        public string Name { get { return _Name; } set { _Name = value; } }
        public int Value { get { return _Value; } set { _Value = value; } }

        #endregion
    }
}
