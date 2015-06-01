using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class DocumentDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Documents. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Documents.</returns>
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
