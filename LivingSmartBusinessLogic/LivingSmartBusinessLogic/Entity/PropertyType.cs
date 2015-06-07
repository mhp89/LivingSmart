namespace LivingSmartBusinessLogic.Entity
{
    /// <summary>
    /// Hold the information for a PropertyType
    /// </summary>
    /// <author>Mathias Pousen</author>
    public class PropertyType
    {
        
        #region Private Fields

        private string _description;
        private bool _deleted;

        #endregion

        #region Properties

        public int Id
        {
            get; 
            internal set;
        }
        public string Description 
        { 
            get { return _description; } 
            internal set { _description = value; } 
        }
        public bool Deleted 
        {
            get { return _deleted; }
            internal set { _deleted = value; }
        }
        
        #endregion

        internal PropertyType(int id, string description, bool deleted)
        {
            Id = id;
            Description = description;
            Deleted = deleted;
        }

        #region Methods

        #endregion
    }
}
