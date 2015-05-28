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
            List<Appointment> appointmentList = new List<Appointment>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Appointment;",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int appointmentId = (int) reader["AppointmentId"];
                    int estateAgentId = (int) reader["EstateAgentId"];
                    int customerId = (int) reader["CustomerId"];
                    int caseId = (int)reader["CaseId"];
                    DateTime startTimestamp = (DateTime)reader["StartTimestamp"];
                    DateTime endTimeStamp = (DateTime)reader["EndTimeStamp"];
                    string description = (string) reader["Description"];
                    string place = (string) reader["Place"];

                    var appointment = new Appointment(appointmentId, caseId, startTimestamp, 0, description, place, customerId);
                    appointmentList.Add(appointment);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return appointmentList;
        }
        public void UpdateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public int CreateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }


    }
}
