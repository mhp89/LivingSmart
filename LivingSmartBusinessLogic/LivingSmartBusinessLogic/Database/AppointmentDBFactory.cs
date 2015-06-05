using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class AppointmentDBFactory
    {
        /// <summary>
        /// Returns the database layer for the Appointments. Type is chosen in the settings file and can be "MSSQL", "XML" or "MYSQL". 
        /// </summary>
        /// <returns>Returns the database layer for the Appointments.</returns>
        /// <author>René Sørensen</author>
        public static IAppointmentDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new AppointmentDBMSSQL();
//            if (Properties.Settings.Default.DatabaseType == "XML")
//                return new AppointmentDBXML();
//            if (Properties.Settings.Default.DatabaseType == "MYSQL")
//                return new AppointmentDBMYSQL();
            return null;
        }
    }
}
