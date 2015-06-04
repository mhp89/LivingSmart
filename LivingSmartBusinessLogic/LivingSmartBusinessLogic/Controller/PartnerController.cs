using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Catalog;
using LivingSmartBusinessLogic.Model;

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

        private PartnerController()
        {
            partnerCatalog = new PartnerCatalog();
        }

        #region Methods
        
        
		public void SetActivePartner(Partner activePartner)
		{
			this.activePartner = activePartner;
		}

        public Partner MakeNewPartner(string name, string telephone, string email, 
            string country, string city, string region, string regionShort, string timeZone)
        {
			SetActivePartner(new Partner(name, telephone, email, country, city, 
                region, regionShort, timeZone));
	        return activePartner;
        }
		public void SaveActivePartner()
		{
			partnerCatalog.Save(activePartner);
			if (activePartner.Id != -1)
				partnerCatalog.AddToCatalog(activePartner);
		}

        
        public Partner ReadPartner(int id)
        {
            return partnerCatalog.Check(id);
        }
		public ReadOnlyCollection<Partner> GetPartners()
		{
			return partnerCatalog.GetPartners();
		}

        #region PropertyMethods
        public void SetName(string name)
        {
            if (activePartner.Name != name)
                activePartner.Name = name;
        }
        public void SetTelephone(string telephone)
        {
            if (activePartner.Telephone != telephone)
                activePartner.Telephone = telephone;
        }
        public void SetCity(string city)
        {
            if (activePartner.City != city)
                activePartner.City = city;
        }
        public void SetCountry(string country)
        {
            if (activePartner.Country != country)
                activePartner.Country = country;
        }
        public void SetRegion(string region)
        {
            if (activePartner.Region != region)
                activePartner.Region = region;
        }
        public void SetRegionShort(string regionShort)
        {
            if (activePartner.RegionShort != regionShort)
                activePartner.RegionShort = regionShort;
        }
        public void SetEmail(string email)
        {
            if (activePartner.Email != email)
                activePartner.Email = email;
        }
        public void SetTimeZone(string timeZone)
        {
            if (activePartner.Timezone != timeZone)
                activePartner.Timezone = timeZone;
        }
        #endregion
        

        #endregion
    }
}
