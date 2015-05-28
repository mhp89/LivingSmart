using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PropertyType
    {
        public int Id { get; private set; }

        #region Private Fields

        private string _description;

        #endregion

        #region Properties

        public string Description { get { return _description; } set { _description = value; } }

        #endregion

        internal PropertyType(int id, string description)
        {
            Id = id;
            _description = description;
        }

        #region Methods

        #endregion
    }
}
