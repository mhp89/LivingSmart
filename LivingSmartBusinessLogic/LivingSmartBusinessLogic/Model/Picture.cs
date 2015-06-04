using System.Drawing;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Hold the information for a Picture
    /// </summary>
    public class Picture
    {


        #region Private Fields

        private string _location;
        private string _description;

        #endregion

        #region Properties
        public int Id { get; internal set; }
        public string Location { get { return _location; } 
            internal set { _location = value; } }
        public string Description { get { return _description; } 
            internal set { _description = value; } }

        #endregion

        internal Picture(string location)
        {
	        Id = -1;
            Location = location;
        }
        internal Picture(int id, string location, string description)
        {
            Id = id;
            Location = location;
            Description = description;
        }

        #region Methods

        #endregion
    }
}
