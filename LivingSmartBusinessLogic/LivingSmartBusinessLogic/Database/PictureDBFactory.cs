using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class PictureDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Pictures. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Pictures.</returns>
        public static IPictureDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new PictureDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new PictureDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new PictureDBMYSQL();
            return null;
        }
    }
}
