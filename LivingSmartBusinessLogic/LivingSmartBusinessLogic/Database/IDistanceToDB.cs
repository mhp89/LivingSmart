using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IDistanceToDB
    {
        Dictionary<int, List<DistanceTo>> ReadDistanceTos();
        List<DistanceTo> ReadDistanceTos(int caseId);
        void UpdateDistanceTo(DistanceTo distanceTo, int caseId);
        int CreateDistanceTo(DistanceTo distanceTo, int caseId);
    }
}
