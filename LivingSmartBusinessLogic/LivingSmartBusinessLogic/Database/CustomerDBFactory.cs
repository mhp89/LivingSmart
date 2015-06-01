using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class CustomerDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Customers. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Customers.</returns>
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
