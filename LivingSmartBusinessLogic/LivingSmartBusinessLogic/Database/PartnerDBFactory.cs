namespace LivingSmartBusinessLogic.Database
{
    internal static class PartnerDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Partners. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Partners.</returns>
        /// <author>René Sørensen</author>
        public static IPartnerDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new PartnerDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new PartnerDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new PartnerDBMYSQL();
            return null;
        }
    }
}
