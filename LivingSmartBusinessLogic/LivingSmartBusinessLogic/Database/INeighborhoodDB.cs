using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface INeighborhoodDB
    {
        List<Neighborhood> ReadNeighborhoods();
        void UpdateNeighborhood(Neighborhood neighborhood);
        int CreateNeighborhood(Neighborhood neighborhood);
    }
}
