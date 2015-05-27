using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    interface IPartnerDB
    {
        List<Partner> ReadPartner();
        void UpdatePartner(Partner partner);
        int CreatePartner(Partner partner);
    }
}
