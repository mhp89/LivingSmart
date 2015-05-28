using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAskingPriceDB
    {
        List<AskingPrice> ReadAskingPrices();
        void UpdateAskingPrice(AskingPrice askingPrice);
        int CreateAskingPrice(AskingPrice askingPrice);
    }
}
