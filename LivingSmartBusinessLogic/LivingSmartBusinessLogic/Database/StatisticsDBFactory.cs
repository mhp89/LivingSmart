namespace LivingSmartBusinessLogic.Database
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
