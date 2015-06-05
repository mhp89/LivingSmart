namespace LivingSmartBusinessLogic.Database
{
    internal static class CityDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Cities. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Cities.</returns>
        public static CityDBMSSQL GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new CityDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new CityDBMXL();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new CityDBMYSQL();
            return null;
        }
    }
}
