namespace LivingSmartBusinessLogic.Entity
{
    /// <summary>
    /// Hold the information for a Partner.
    /// </summary>
    /// <author>Mathias Pousen</author>
    public class Partner
    {

        #region Private Fields

        private string _name;
        private string _telephone;
        private string _email;
        private string _city;
        private string _country;
        private string _region;
        private string _regionShort;
        private string _timezone;

        #endregion

        #region Properties

        public int Id
        {
            get; 
            internal set;
        }

        public string Name
        {
            get { return _name; } 
            internal set { _name = value; }
        }
        public string Telephone 
        { 
            get { return _telephone; } 
            internal set { _telephone = value; } 
        }

        public string Email
        {
            get { return _email; } 
            internal set { _email = value; }
        }

        public string City
        {
            get { return _city; } 
            internal set { _city = value; }
        }

        public string Country
        {
            get { return _country; } 
            internal set { _country = value; }
        }

        public string Region
        {
            get { return _region; } 
            internal set { _region = value; }
        }
        public string RegionShort 
        { 
            get { return _regionShort; } 
            internal set { _regionShort = value; } 
        }

        public string Timezone
        {
            get { return _timezone; } 
            internal set { _timezone = value; }
        }

        #endregion

        internal Partner(string name, string telephone, string email, string country, 
            string city, string region, string regionShort, string timeZone)
		{
			Id = -1;
            Name = name;
            Telephone = telephone;
            Email = email;
            Country = country;
            City = city;
            Region = region;
            RegionShort = regionShort;
            Timezone = timeZone;
        }
        internal Partner(int id, string name, string telephone, string email, 
            string country, string city, string region, string regionShort, string timeZone)
        {
            Id = id;
            Name = name;
            Telephone = telephone;
            Email = email;
            Country = country;
            City = city;
            Region = region;
            RegionShort = regionShort;
            Timezone = timeZone;
        }

        #region Methods

        #endregion
    }
}
