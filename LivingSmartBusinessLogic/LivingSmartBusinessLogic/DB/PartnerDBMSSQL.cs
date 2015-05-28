using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;

namespace LivingSmartBusinessLogic.DB
{
    internal class PartnerDBMSSQL : IPartnerDB
    {
        public List<Partner> ReadPartners()
        {
            throw new NotImplementedException();
        }

        public void UpdatePartner(Partner partner)
        {
            throw new NotImplementedException();
        }

        public int CreatePartner(Partner partner)
        {
            throw new NotImplementedException();
        }
    }
}
