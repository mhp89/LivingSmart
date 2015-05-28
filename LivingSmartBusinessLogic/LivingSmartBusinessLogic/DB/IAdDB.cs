﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAdDB
    {
        List<Ad> ReadAds(int caseId);
        List<Ad> ReadAds();
        void UpdateAd(Ad ad, int caseId);
        int CreateAd(Ad ad, int caseId);
    }
}
