using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Rating
    {
        private int Id;

        #region Private Fields

        private int _EstateAgentValue;
        private int _SystemValue;
        private int _Date;

        #endregion

        #region Properties

        public int EstateAgentValue { get { return _EstateAgentValue; } set { _EstateAgentValue = value; } }
        public int SystemValue { get { return _SystemValue; } set { _SystemValue = value; } }
        public int Date { get { return _Date; } set { _Date = value; } }

        #endregion
    }
}
