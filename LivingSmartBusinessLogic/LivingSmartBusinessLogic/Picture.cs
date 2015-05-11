using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Picture
    {
        private int id;

        #region Private Fields

        private string _location;
        private string _desription;

        #endregion

        #region Properties

        public string Location { get { return _location; } set { _location = value; } }
        public string Desription { get { return _desription; } set { _desription = value; } }

        #endregion

        #region Methods

        #endregion
    }
}
