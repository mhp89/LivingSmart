using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IDistanceToDB
    {
        List<DistanceTo> ReadDistanceTos();
        void UpdateDistanceTo(DistanceTo distanceTo);
        int CreateDistanceTo(DistanceTo distanceTo);
    }
}
