namespace LivingSmartBusinessLogic.Entity
{
    /// <summary>
    /// Holds the information for a City
    /// </summary>
    /// <author>Mathias Pousen</author>
    public class City
    {
        #region Private Fields

        private int _zipcode;
        private string _district;

        #endregion

        #region Properties

        public int ZipCode
        {
            get
            {
                return _zipcode;
            }
            internal set
            {
                _zipcode = value;
            }
        }

        public string District
        {
            get
            {
                return _district;
            }
            internal set
            {
                _district = value;
            }
        }
		public string NiceDisplay { get { return ZipCode + " " + District; } }

        #endregion

        internal City(int zipCode, string district)
        {
            ZipCode = zipCode;
            District = district;
        }

        #region Methods

        #endregion
    }
}
