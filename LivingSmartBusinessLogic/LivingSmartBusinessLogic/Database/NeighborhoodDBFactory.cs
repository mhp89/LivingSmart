using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class NeighborhoodDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Neighborhoods. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Neighborhoods.</returns>
        /// <author>René Sørensen</author>
        public static INeighborhoodDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new NeighborhoodDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new NeighborhoodDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new NeighborhoodDBMYSQL();
            return null;
        }
    }
}
