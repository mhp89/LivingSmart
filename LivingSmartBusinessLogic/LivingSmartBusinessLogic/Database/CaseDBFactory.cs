namespace LivingSmartBusinessLogic.Database
{
    internal static class CaseDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Cases. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Cases.</returns>
        /// <author>René Sørensen</author>
        public static CaseDBMSSQL GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new CaseDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new CaseDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new CaseDBMYSQL();
            return null;
        }
    }
}
