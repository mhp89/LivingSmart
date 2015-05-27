using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    interface IAdDB
    {
        List<Ad> ReadAds();
        void UpdateAd(Ad ad);
        int CreateAd(Ad ad);
    }
}
