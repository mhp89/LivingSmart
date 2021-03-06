namespace LivingSmartBusinessLogic.Entity
{
    /// <summary>
    /// Holds the information for a Document.
    /// </summary>
    /// <author>Mathias Pousen</author>
    public class Document
    {

        #region Private Fields

        private string _type;
        private int _price;
        private string _location;

        #endregion

        #region Properties

        public int Id
        {
            get; 
            internal set;
        }

        public string Type
        {
            get { return _type; } 
            internal set { _type = value; }
        }

        public int Price
        {
            get { return _price; } 
            internal set { _price = value; }
        }

        public string Location
        {
            get { return _location; } 
            internal set { _location = value; }
        }

        #endregion

        internal Document(string type, int price, string location)
		{
			Id = -1;
            Type = type;
            Price = price;
            Location = location;
        }
        internal Document(int id, string type, int price, string location)
        {
            Id = id;
            Type = type;
            Price = price;
            Location = location;
        }

        #region Methods

        #endregion
    }
}
