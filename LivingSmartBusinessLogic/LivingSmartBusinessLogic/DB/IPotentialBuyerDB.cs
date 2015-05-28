using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IPotentialBuyerDB
    {
        List<PotentialBuyer> ReadPotentialBuyers();
        void UpdatePotentialBuyer(PotentialBuyer ca);
        int CreatePotentialBuyer(PotentialBuyer ca);
    }
}
