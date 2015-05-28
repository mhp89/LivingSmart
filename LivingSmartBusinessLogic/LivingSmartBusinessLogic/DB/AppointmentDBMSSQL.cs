using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;

namespace LivingSmartBusinessLogic.DB
{
    internal class AppointmentDBMSSQL : IAppointmentDB
    {
        public List<Appointment> ReadAppointments()
        {
            throw new NotImplementedException();
        }

        public void UpdateAd(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public int CreateAd(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
