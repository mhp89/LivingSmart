using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
    /// <summary>
    /// Partnercontroller
    /// </summary>
    /// <author>Mathias Pousen</author>
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
        
        /// <summary>
        /// S�tter aktiv partner
        /// </summary>
        /// <param name="activePartner"></param>
        /// <author>Mathias Petersen</author>
		public void SetActivePartner(Partner activePartner)
		{
			this.activePartner = activePartner;
		}
        /// <summary>
        /// Laver og returnerer en ny partner
        /// </summary>
        /// <param name="name"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="regionShort"></param>
        /// <param name="timeZone"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public Partner MakeNewPartner(string name, string telephone, string email, 
            string country, string city, string region, string regionShort, string timeZone)
        {
			SetActivePartner(new Partner(name, telephone, email, country, city, 
                region, regionShort, timeZone));
	        return activePartner;
        }
        /// <summary>
        /// Gemmer den aktive partner
        /// </summary>
        /// <author>Mathias Petersen</author>
		public void SaveActivePartner()
		{
			partnerCatalog.Save(activePartner);
			if (activePartner.Id != -1)
				partnerCatalog.AddToCatalog(activePartner);
		}

        /// <summary>
        /// Henter en given partner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <author>Mathias Poulsen</author>
        public Partner ReadPartner(int id)
        {
            return partnerCatalog.Check(id);
        }
        /// <summary>
        /// Henter alle partnere
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
		public ReadOnlyCollection<Partner> GetPartners()
		{
			return partnerCatalog.GetPartners();
		}

        #region PropertyMethods
        /// <summary>
        /// S�tter navn p� den aktive partner
        /// </summary>
        /// <param name="name"></param>
        /// <author>Mathias Poulsen</author>
        public void SetName(string name)
        {
            if (activePartner.Name != name)
                activePartner.Name = name;
        }
        /// <summary>
        /// S�tter telefonnummer p� den aktive partner
        /// </summary>
        /// <param name="telephone"></param>
        public void SetTelephone(string telephone)
        {
            if (activePartner.Telephone != telephone)
                activePartner.Telephone = telephone;
        }
        /// <summary>
        /// S�tter by p� den aktive partner
        /// </summary>
        /// <param name="city"></param>
        public void SetCity(string city)
        {
            if (activePartner.City != city)
                activePartner.City = city;
        }
        /// <summary>
        /// S�tter land p� den aktive partner
        /// </summary>
        /// <param name="country"></param>
        /// <author>Mathias Poulsen</author>
        public void SetCountry(string country)
        {
            if (activePartner.Country != country)
                activePartner.Country = country;
        }
        /// <summary>
        /// S�tter region p� den aktive partner
        /// </summary>
        /// <param name="region"></param>
        /// <author>Mathias Poulsen</author>
        public void SetRegion(string region)
        {
            if (activePartner.Region != region)
                activePartner.Region = region;
        }
        /// <summary>
        /// S�tter regionsforkortelse p� den aktive region
        /// </summary>
        /// <param name="regionShort"></param>
        /// <author>Mathias Poulsen</author>
        public void SetRegionShort(string regionShort)
        {
            if (activePartner.RegionShort != regionShort)
                activePartner.RegionShort = regionShort;
        }
        /// <summary>
        /// S�tter email p� den aktive partner
        /// </summary>
        /// <param name="email"></param>
        public void SetEmail(string email)
        {
            if (activePartner.Email != email)
                activePartner.Email = email;
        }
        /// <summary>
        /// S�tter tidszone p� den aktive partner
        /// </summary>
        /// <param name="timeZone"></param>
        /// <author>Mathias Poulsen</author>
        public void SetTimeZone(string timeZone)
        {
            if (activePartner.Timezone != timeZone)
                activePartner.Timezone = timeZone;
        }
        #endregion
        

        #endregion
    }
}
