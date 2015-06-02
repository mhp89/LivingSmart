namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Holds the information for a Document.
    /// </summary>
    public class Document
    {

        #region Private Fields

        private string _type;
        private int _price;
        private string _location;
        private string _status;

        #endregion

        #region Properties

        public int Id { get; private set; }
        public string Type { get { return _type; } internal set { _type = value; } }
        public int Price { get { return _price; } internal set { _price = value; } }
        public string Location { get { return _location; } internal set { _location = value; } }
        public string Status { get { return _status; } internal set { _status = value; } }

        #endregion

        internal Document(string type, int price, string location, string status)
		{
			Id = -1;
            Type = type;
            Price = price;
            Location = location;
            Status = status;
        }
        internal Document(int id, string type, int price, string location, string status)
        {
            Id = id;
            Type = type;
            Price = price;
            Location = location;
            Status = status;
        }

        #region Methods

        #endregion
    }
}
