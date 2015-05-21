using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PartnerCatalog
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
