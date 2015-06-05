namespace LivingSmartBusinessLogic.Database
{
    internal static class EstateAgentDBFactory
    {
        /// <summary>
        /// Returns the database layer for the EstateAgents. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the EstateAgents.</returns>
        public static IEstateAgentDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new EstateAgentDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new EstateAgentDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new EstateAgentDBMYSQL();
            return null;
        }
    }
}
