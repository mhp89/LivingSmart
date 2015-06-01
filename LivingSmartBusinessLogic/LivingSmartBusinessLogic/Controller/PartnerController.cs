using LivingSmartBusinessLogic.Catalog;

namespace LivingSmartBusinessLogic.Controller
{
    public class PartnerController
	{
		#region Singleton

		private static PartnerController _instance;
		public static PartnerController Instance
		{
			get { return _instance ?? (_instance = new PartnerController()); }
		}

		#endregion


        private PartnerCatalog partnerCatalog;

        private Partner activePartner;

        public PartnerController()
        {
            partnerCatalog = new PartnerCatalog();
        }

        #region Methods
        
        public void AddPartner(Partner partner)
        {
            partnerCatalog.AddToCatalog(partner);
        }

        public Partner MakeNewPartner(string name, string telephone, string email, 
            string country, string city, string region, string regionShort, string timeZone)
        {
            return new Partner(name, telephone, email, country, city, 
                region, regionShort, timeZone);
        }
        
        public Partner ReadPartner(int id)
        {
            return partnerCatalog.Check(id);
        }

        public void UpdatePartner(Partner partner)
        {
            partnerCatalog.Save(partner);
        }

        #region PropertyMethods
        public void SetName(Partner partner, string name)
        {
            if (partner.Name != name)
                partner.Name = name;
        }
        public void SetTelephone(Partner partner, string telephone)
        {
            if (partner.Telephone != telephone)
                partner.Telephone = telephone;
        }
        public void SetCity(Partner partner, string city)
        {
            if (partner.City != city)
                partner.City = city;
        }
        public void SetCountry(Partner partner, string country)
        {
            if (partner.Country != country)
                partner.Country = country;
        }
        public void SetRegion(Partner partner, string region)
        {
            if (partner.Region != region)
                partner.Region = region;
        }
        public void SetRegionShort(Partner partner, string regionShort)
        {
            if (partner.RegionShort != regionShort)
                partner.RegionShort = regionShort;
        }
        public void SetEmail(Partner partner, string email)
        {
            if (partner.Email != email)
                partner.Email = email;
        }
        public void SetTimeZone(Partner partner, string timeZone)
        {
            if (partner.Timezone != timeZone)
                partner.Timezone = timeZone;
        }
        #endregion
        

        #endregion
    }
}
