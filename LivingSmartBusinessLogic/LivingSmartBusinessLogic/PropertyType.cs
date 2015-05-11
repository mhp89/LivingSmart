using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PropertyType
    {
        private int id;

        #region Private Fields

        private string _description;

        #endregion

        #region Properties

        public string Description { get { return _description; } set { _description = value; } }

        #endregion

        #region Methods

        #endregion
    }
}
