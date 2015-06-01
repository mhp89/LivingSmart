using System;
using System.Collections.Generic;
using System.Text;

namespace LivingSmartBusinessLogic.DB
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Maja Olesen</author>
    internal interface IStatisticsDB
    {
        /// <summary>
        /// Returnerer en liste med statistik en en bestemt mægler og et bestemt år
        /// </summary>
        /// <param name="estateAgentId"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        List<Statistics> ReadEstateAgentStatistics(int estateAgentId, int year);

        /// <summary>
        /// Returnerer en liste med statistik for alle solgte ejendomme
        /// </summary>
        /// <returns></returns>
        List<Statistics> ReadAllStatistics();

        /// <summary>
        /// Returnerer statistik for solgte ejendomme i indeværende år
        /// </summary>
        /// <returns></returns>
        Statistics ReadDialStatistics();
    }
}
