using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    static class AdDBFactory
    {
        public static IAdDB GetDBL()
        {
            if (Properties.Settings.Default.Database == "MSSQL")
                return new AdDBMSSQL();
//            if (Properties.Settings.Default.Database == "XML")
//                return new AdDBXML();
//            if (Properties.Settings.Default.Database == "MYSQL")
//                return new CustomerDBMYSQL();
            return null;
        }
    }
}
