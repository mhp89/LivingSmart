namespace LivingSmartBusinessLogic.Database
{
    internal static class AskingPriceDBFactory
    {
        /// <summary>
        /// Returns the database layer for the AskingPrices. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the AskingPrices.</returns>
        public static IAskingPriceDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new AskingPriceDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new AskingPriceDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new AskingPriceDBMYSQL();
            return null;
        }
    }
}
