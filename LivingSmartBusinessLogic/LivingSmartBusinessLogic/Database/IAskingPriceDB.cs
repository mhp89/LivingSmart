using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAskingPriceDB
    {
        List<AskingPrice> ReadAskingPrices(int caseId);
        void UpdateAskingPrice(AskingPrice askingPrice, int caseId);
        int CreateAskingPrice(AskingPrice askingPrice, int caseId);
    }
}
