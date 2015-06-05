namespace LivingSmartBusinessLogic.Database
{
    internal static class RatingDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Ratings. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Ratings.</returns>
        /// <author>René Sørensen</author>
        public static IRatingDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new RatingDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new RatingDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new RatingDBMYSQL();
            return null;
        }
    }
}
