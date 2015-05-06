using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Picture
    {
        private int Id;

        #region Private Fields

        private int _Location;
        private string _Desription;

        #endregion

        #region Properties

        public int Location { get { return _Location; } set { _Location = value; } }
        public string Desription { get { return _Desription; } set { _Desription = value; } }

        #endregion
    }
}
