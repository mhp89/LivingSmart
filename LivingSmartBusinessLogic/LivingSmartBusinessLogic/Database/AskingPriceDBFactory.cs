using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class AskingPriceDBFactory
    {
        /// <summary>
        /// Returns the database layer for the AskingPrices. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the AskingPrices.</returns>
        /// <author>René Sørensen</author>
        public static IAskingPriceDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new AskingPriceDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new AskingPriceDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new AskingPriceDBMYSQL();
            return null;
        }
    }
}
