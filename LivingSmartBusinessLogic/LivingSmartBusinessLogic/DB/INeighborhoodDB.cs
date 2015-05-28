using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface INeighborhoodDB
    {
        List<Document> ReadNeighborhoods();
        void UpdateDocument(Neighborhood neighborhood);
        int CreateDocument(Neighborhood neighborhood);
    }
}
