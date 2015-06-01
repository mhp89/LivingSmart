using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class PartnerCatalog
    {
        private Dictionary<int,Partner> partners;

        internal PartnerCatalog()
        {
            partners = new Dictionary<int, Partner>();
        }

        internal Partner Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(Partner partner)
        {
            throw new System.NotImplementedException();
        }

        internal void AddToCatalog(Partner partner)
        {
            partners.Add(partner.Id, partner);
        }

        internal void RemoveFromCatalog(Partner partner)
        {
            partners.Add(partner.Id, partner);
        }
    }
}
