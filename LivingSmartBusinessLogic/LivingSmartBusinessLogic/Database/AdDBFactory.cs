namespace LivingSmartBusinessLogic.Database
{
    internal static class AdDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Ads. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Ads.</returns>
        /// <author>René Sørensen</author>
        public static IAdDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new AdDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new AdDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new AdDBMYSQL();
            return null;
        }
    }
}
