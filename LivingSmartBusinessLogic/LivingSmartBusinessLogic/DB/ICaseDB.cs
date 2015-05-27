using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    interface ICaseDB
    {
        List<Case> ReadCases();
        void UpdateAd(Case ca);
        int CreateAd(Case ca);
    }
}
