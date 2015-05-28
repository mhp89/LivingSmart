using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAppointmentDB
    {
        List<Appointment> ReadAppointments();
        void UpdateAd(Appointment appointment);
        int CreateAd(Appointment appointment);
    }
}
