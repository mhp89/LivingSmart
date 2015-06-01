using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface ICaseDB
    {
        List<Case> ReadCases(int estateAgentUId);
        void UpdateCase(Case ca);
        int CreateCase(Case ca);
    }
}
