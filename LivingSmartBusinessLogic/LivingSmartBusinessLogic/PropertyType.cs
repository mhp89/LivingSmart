using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public PropertyType(int id, string description)
        {
            this.id = id;
            _description = description;
        }

        #region Methods

        #endregion
    }
}
