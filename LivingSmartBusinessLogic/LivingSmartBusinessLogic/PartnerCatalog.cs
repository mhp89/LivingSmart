using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PartnerCatalog
    {
        private System.Collections.Generic.List<LivingSmartBusinessLogic.Partner> partners;

        public Partner Check(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Partner partner)
        {
            throw new System.NotImplementedException();
        }

        public void AddToCatalog(Partner partner)
        {
            partners.Add(partner);
        }

        public void RemoveFromCatalog(Partner partner)
        {
            partners.Add(partner);
        }
    }
}
