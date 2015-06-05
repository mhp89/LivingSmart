using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.Model;
using LivingSmartBusinessLogic.DB;

namespace LivingSmartBusinessLogic.Catalog
{
    /// <summary>
    /// Partnerkatalog
    /// </summary>
    internal class PartnerCatalog
    {
        private Dictionary<int, Partner> partners;

        private IPartnerDB db;
        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Petersen</author>
        internal PartnerCatalog()
        {
            db = PartnerDBFactory.GetDBL();
            partners = new Dictionary<int, Partner>();

            LoadCatalog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <author>Mathias Petersen</author>
        internal void LoadCatalog()
        {
            var customerList = db.ReadPartners();
            foreach (var customer in customerList)
                AddToCatalog(customer);
        }

        internal Partner Check(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="partner"></param>
        /// <author>Mathias Petersen</author>
        internal void Save(Partner partner)
        {
            if (partner.Id == -1)
                partner.Id = partner.Id = db.CreatePartner(partner);
            else
                db.UpdatePartner(partner);
        }

        internal void AddToCatalog(Partner partner)
        {
			if(!partners.ContainsKey(partner.Id))
				partners.Add(partner.Id, partner);
        }

        internal void RemoveFromCatalog(Partner partner)
        {
            if (partners.ContainsKey(partner.Id))
                partners.Remove(partner.Id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
        internal ReadOnlyCollection<Partner> GetPartners()
        {
            var partnerList = new List<Partner>();
            partnerList.AddRange(partners.Values);
            return partnerList.AsReadOnly();
        }
    }
}
