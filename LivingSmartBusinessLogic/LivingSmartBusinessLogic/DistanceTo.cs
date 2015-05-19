using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class DistanceTo
    {
        private int id;

        #region Private Fields

        private string _type;
        private int _distance;

        #endregion

        #region Properties

        public string Type { get { return _type; } set { _type = value; } }
        public int Distance { get { return _distance; } set { _distance = value; } }

        #endregion

        #region Methods

        #endregion
    }
}
