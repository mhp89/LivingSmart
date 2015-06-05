namespace LivingSmartBusinessLogic.Database
{
    internal static class PropertyTypeDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Propertys. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Propertys.</returns>
        public static IPropertyTypeDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new PropertyTypeDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new PropetyTypeDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new PropertyTypeDBMYSQL();
            return null;
        }
    }
}
