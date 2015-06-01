using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAdDB
    {
        List<Ad> ReadAds(int caseId);
        Dictionary<int, List<Ad>> ReadAds();
        void UpdateAd(Ad ad, int caseId);
        int CreateAd(Ad ad, int caseId);
    }
}
