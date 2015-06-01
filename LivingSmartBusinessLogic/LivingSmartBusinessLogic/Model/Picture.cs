namespace LivingSmartBusinessLogic.Model
{
    public class Picture
    {


        #region Private Fields

        private string _location;
        private string _description;

        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Location { get { return _location; } 
            internal set { _location = value; } }
        public string Desription { get { return _description; } 
            internal set { _description = value; } }

        #endregion

        internal Picture(string location, string description)
        {
            Location = location;
            Desription = description;
        }
        internal Picture(int id, string location, string description)
        {
            Id = id;
            Location = location;
            Desription = description;
        }

        #region Methods

        #endregion
    }
}
