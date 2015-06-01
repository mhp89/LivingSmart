using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class StatisticsDBFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <author>Maja Olesen</author>
        public static IStatisticsDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new StatisticsDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new CustomerDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new CustomerDBMYSQL();
            return null;
        }
    }
}
