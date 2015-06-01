using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IAppointmentDB
    {
        Dictionary<int, List<Appointment>> ReadAppointments();
        void UpdateAppointment(Appointment appointment, int estateAgentId);
        int CreateAppointment(Appointment appointment, int estateAgentId);
    }
}
