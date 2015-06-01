using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal class AppointmentDBMSSQL : IAppointmentDB
    {
        public Dictionary<int, List<Appointment>> ReadAppointments()
        {
            Dictionary<int, List<Appointment>> appointments = new Dictionary<int, List<Appointment>>();
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
                    int appointmentId = (int)reader["AppointmentId"];
                    int estateAgentId = (int)reader["EstateAgentId"];
                    int customerId = (int)reader["CustomerId"];
                    int caseId = (int)reader["CaseId"];
                    DateTime startTimestamp = (DateTime)reader["StartTimestamp"];
                    DateTime endTimeStamp = (DateTime)reader["EndTimeStamp"];
                    string description = (string)reader["Description"];
                    string place = (string)reader["Place"];

                    var appointment = new Appointment(appointmentId, caseId, startTimestamp, endTimeStamp, description, place, customerId);
                    if (!appointments.ContainsKey(estateAgentId))
                    {
                        appointments.Add(estateAgentId, new List<Appointment>());
                    }
                    appointments[estateAgentId].Add(appointment);
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

            return appointments;
        }

        public void UpdateAppointment(Appointment appointment, int estateAgentId)
        {
            int appointmentId = appointment.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Ad SET EstateAgentId = (@estateAgentId), CustomerId = (@CustomerId), CaseId = (@CaseId), StartTimestamp = (@StartTimestamp), EndTimeStamp = (@EndTimeStamp), Description = (@Description), Place = (@Place)" + "WHERE AppointmentId = " + appointmentId
            };

            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 50, "EstateAgentId").Value = estateAgentId;
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int, 50, "CustomerId").Value = appointment.Customer.Id;
            cmd.Parameters.Add("@CaseId", SqlDbType.Date, 50, "CaseId").Value = appointment.Case.Id;
            cmd.Parameters.Add("@StartTimestamp", SqlDbType.Date, 50, "StartTimestamp").Value = appointment.StartTimestamp;
            cmd.Parameters.Add("@EndTimeStamp", SqlDbType.Int, 50, "EndTimeStamp").Value = appointment.EndTimeStamp;
            cmd.Parameters.Add("@Description", SqlDbType.Int, 50, "Description").Value = appointment.Description;
            cmd.Parameters.Add("@Place", SqlDbType.Int, 50, "Place").Value = appointment.Place;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public int CreateAppointment(Appointment appointment, int estateAgentId)
        {
            int appointmentId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Appointment VALUES (@EstateAgentId, @CustomerId, @CaseId, @StartTimestamp, @EndTimeStamp, @Description, @Place); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Date, 50, "EstateAgentId").Value = estateAgentId;
            cmd.Parameters.Add("@CustomerId", SqlDbType.Date, 50, "CustomerId").Value = appointment.Customer.Id;
            cmd.Parameters.Add("@CaseId", SqlDbType.Date, 50, "CaseId").Value = appointment.Case.Id;
            cmd.Parameters.Add("@StartTimestamp", SqlDbType.Int, 50, "StartTimestamp").Value = appointment.StartTimestamp;
            cmd.Parameters.Add("@EndTimeStamp", SqlDbType.Int, 50, "EndTimeStamp").Value = appointment.EndTimeStamp;
            cmd.Parameters.Add("@Description", SqlDbType.Int, 50, "Description").Value = appointment.Description;
            cmd.Parameters.Add("@Place", SqlDbType.Int, 50, "Place").Value = appointment.Place;

            try
            {
                connection.Open();
                appointmentId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return appointmentId;
        }
    }
}
