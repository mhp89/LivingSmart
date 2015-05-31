using System;
using System.Collections.Generic;
using System.Text;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IStatisticsDB
    {
        List<Statistics> ReadEstateAgentStatistics(int estateAgentId, int year);

        List<Statistics> ReadAllStatistics();
    }
}
