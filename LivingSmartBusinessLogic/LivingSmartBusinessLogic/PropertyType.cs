using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PropertyType
    {
        private int Id;

        #region Private Fields

        private int _Description;

        #endregion

        #region Properties

        public int Description { get { return _Description; } set { _Description = value; } }

        #endregion
    }
}
