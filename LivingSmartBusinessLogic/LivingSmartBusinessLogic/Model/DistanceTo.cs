namespace LivingSmartBusinessLogic.Model
{
    public class DistanceTo
    {
        
        #region Private Fields

        private string _type;
        private int _distance;

        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Type { get { return _type; } internal set { _type = value; } }
        public int Distance { get { return _distance; } internal set { _distance = value; } }

        #endregion

        internal DistanceTo(string type, int distance)
        {
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
