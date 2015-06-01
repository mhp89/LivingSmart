namespace LivingSmartBusinessLogic.Model
{
    public class PropertyType
    {
        
        #region Private Fields

        private string _description;

        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Description { get { return _description; } 
            internal set { _description = value; } }

        #endregion

        internal PropertyType(int id, string description)
        {
            Id = id;
            Description = description;
        }

        #region Methods

        #endregion
    }
}
