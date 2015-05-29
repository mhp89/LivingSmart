using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface ICaseDB
    {
        List<Case> ReadCases();
        void UpdateCase(Case ca);
        int CreateCase(Case ca);
    }
}
