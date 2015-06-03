using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.Model;
using LivingSmartBusinessLogic.DB;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class PartnerCatalog
    {
		private Dictionary<int, Partner> partners;

		private IPartnerDB db;

        internal PartnerCatalog()
		{
			db = PartnerDBFactory.GetDBL();
            partners = new Dictionary<int, Partner>();

	        LoadCatalog();
		}
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

        internal void Save(Partner partner)
		{
			if (partner.Id == -1)
				partner.Id = partner.Id = db.CreatePartner(partner);
			else
				db.UpdatePartner(partner);
        }

        internal void AddToCatalog(Partner partner)
        {
            partners.Add(partner.Id, partner);
        }

        internal void RemoveFromCatalog(Partner partner)
        {
            partners.Add(partner.Id, partner);
        }

		internal ReadOnlyCollection<Partner> GetPartners()
		{
		    var partnerList = new List<Partner>();
            partnerList.AddRange(partners.Values);
			return partnerList.AsReadOnly();
		}
    }
}
