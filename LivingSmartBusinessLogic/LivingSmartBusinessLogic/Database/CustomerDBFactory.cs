namespace LivingSmartBusinessLogic.Database
{
    internal static class CustomerDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Customers. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Customers.</returns>
        /// <author>René Sørensen</author>
        public static ICustomerDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new CustomerDBMSSQL();
            if (Properties.Settings.Default.DatabaseType == "XML")
                return new CustomerDBXML();
            if (Properties.Settings.Default.DatabaseType == "MYSQL")
                return new CustomerDBMYSQL();
            return null;
        }
    }
}
