using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class DistanceTo
    {
        public int Id { get; private set; }

        #region Private Fields

        private string _type;
        private int _distance;

        #endregion

        #region Properties

        public string Type { get { return _type; } internal set { _type = value; } }
        public int Distance { get { return _distance; } internal set { _distance = value; } }

        #endregion

        internal DistanceTo()
        {
            
        }
        internal DistanceTo(int id, string type, int distance)
        {
            Id = id;
            Type = type;
            Distance = distance;
        }

        #region Methods

        #endregion
    }
}
