using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IPartnerDB
    {
        List<Partner> ReadPartners();
        void UpdatePartner(Partner partner);
        int CreatePartner(Partner partner);
    }
}
