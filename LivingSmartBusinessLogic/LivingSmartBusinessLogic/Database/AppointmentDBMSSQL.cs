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
        /// <summary>
        /// Returns a dictionary containing all the appointments in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the appointments in the database, with estateAgentId as key and a list of appointments containing that estateAgentId</returns>
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

        /// <summary>
        /// Updates the information from and appointment, in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be updated.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        public void UpdateAppointment(Appointment appointment, int estateAgentId)
        {
            int appointmentId = appointment.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Ad SET EstateAgentId = (@estateAgentId), CustomerId = (@CustomerId), CaseId = (@CaseId), StartTimestamp = (@StartTimestamp), EndTimeStamp = (@EndTimeStamp), Description = (@Description), Place = (@Place)" + "WHERE AppointmentId = " + appointmentId
            };

            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = estateAgentId;
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int, 4, "CustomerId").Value = appointment.Customer.Id;
            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = appointment.Case.Id;
            cmd.Parameters.Add("@StartTimestamp", SqlDbType.Date, 8, "StartTimestamp").Value = appointment.StartTimestamp;
            cmd.Parameters.Add("@EndTimeStamp", SqlDbType.Date, 8, "EndTimeStamp").Value = appointment.EndTimeStamp;
            cmd.Parameters.Add("@Description", SqlDbType.Char, 500, "Description").Value = appointment.Description;
            cmd.Parameters.Add("@Place", SqlDbType.Char, 500, "Place").Value = appointment.Place;

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

        /// <summary>
        /// Creates an appointment in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be created.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        /// <returns>Returns the Id of the Appointment created.</returns>
        public int CreateAppointment(Appointment appointment, int estateAgentId)
        {
            int appointmentId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Appointment OUTPUT INSERTED.ID VALUES (@EstateAgentId, @CustomerId, @CaseId, @StartTimestamp, @EndTimeStamp, @Description, @Place); "
            };

            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = estateAgentId;
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int, 4, "CustomerId").Value = appointment.Customer.Id;
            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = appointment.Case.Id;
            cmd.Parameters.Add("@StartTimestamp", SqlDbType.Date, 8, "StartTimestamp").Value = appointment.StartTimestamp;
            cmd.Parameters.Add("@EndTimeStamp", SqlDbType.Date, 8, "EndTimeStamp").Value = appointment.EndTimeStamp;
            cmd.Parameters.Add("@Description", SqlDbType.Char, 500, "Description").Value = appointment.Description;
            cmd.Parameters.Add("@Place", SqlDbType.Char, 500, "Place").Value = appointment.Place;

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
