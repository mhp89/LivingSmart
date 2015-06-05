namespace LivingSmartBusinessLogic.Database
{
    internal static class DocumentDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Documents. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Documents.</returns>
        /// <author>René Sørensen</author>
        public static IDocumentDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new DocumentDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new DocumentDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new DocumentDBMYSQL();
            return null;
        }
    }
}
