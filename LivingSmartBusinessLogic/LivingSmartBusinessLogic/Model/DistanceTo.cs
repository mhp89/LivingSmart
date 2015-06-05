namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Holds the information for distances to Shopping, School, Center, etc.
    /// </summary>
    /// <author>Mathias Pousen</author>
    public class DistanceTo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Petersen</author>
	    public enum DistanceToSystemType
	    {
		    Shopping,
			School,
			Center
	    }

        #region Private Fields

        private string _type;
        private int _distance;

        #endregion

        #region Properties
        public int Id { get; internal set; }
        public string Type { get { return _type; } internal set { _type = value; } }
        public int Distance { get { return _distance; } internal set { _distance = value; } }

        #endregion

        internal DistanceTo(string type, int distance)
		{
			Id = -1;
            Type = type;
            Distance = distance;
        }
        internal DistanceTo(int id, string type, int distance)
        {
            Id = id;
            Type = type;
            Distance = distance;
        }

        #region Methods

        #endregion
    }
}
