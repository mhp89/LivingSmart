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
        private string _description;

        #endregion

        #region Properties

        public string Location { get { return _location; } internal set { _location = value; } }
        public string Desription { get { return _description; } internal set { _description = value; } }

        #endregion

        internal Picture(int id, string location, string description)
        {
            this.id = id;
            _location = location;
            _description = description;
        }

        #region Methods

        #endregion
    }
}
