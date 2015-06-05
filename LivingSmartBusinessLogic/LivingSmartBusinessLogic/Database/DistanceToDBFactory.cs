using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class DistanceToDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Distances. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Distances.</returns>
        /// <author>René Sørensen</author>
        public static IDistanceToDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new DistanceToDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new DistanceDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new DistanceDBMYSQL();
            return null;
        }
    }
}
