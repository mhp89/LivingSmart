using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class NeighborhoodDBFactory
    {
        public static INeighborhoodDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new NeighborhoodDBMSSQL();
//            if (Properties.Settings.Default.Database == "XML")
//                return new CustomerDBXML();
//            if (Properties.Settings.Default.Database == "MYSQL")
//                return new CustomerDBMYSQL();
            return null;
        }
    }
}
