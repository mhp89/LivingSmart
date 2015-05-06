using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class DistanceTo
    {
        private int Id;

        #region Private Fields

        private int _Type;
        private int _Distance;

        #endregion

        #region Properties

        public int Type { get { return _Type; } set { _Type = value; } }
        public int Distance { get { return _Distance; } set { _Distance = value; } }

        #endregion
    }
}
