using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PartnerController
    {
        private PartnerCatalog partnerCatalog;

        public PartnerController()
        {
            partnerCatalog = new PartnerCatalog();
        }

        public void AddPartner(Partner partner)
        {
            partnerCatalog.AddToCatalog(partner);
        }

        public Partner MakeNewPartner()
        {
            return new Partner();
        }

        public Partner ReadPartner(int id)
        {
            return partnerCatalog.Check(id);
        }

        public void UpdatePartner(Partner partner)
        {
            partnerCatalog.Save(partner);
        }
    }
}
