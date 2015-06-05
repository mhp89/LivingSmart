using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal class AppointmentDBMSSQL : IAppointmentDB
    {
        /// <summary>
        /// Returns a dictionary containing all the appointments in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the appointments in the database, with estateAgentId as key and a list of appointments containing that estateAgentId</returns>
        /// <author>René Sørensen</author>
        public Dictionary<int, List<Appointment>> ReadAppointments()
        {
            Dictionary<int, List<Appointment>> appointments = new Dictionary<int, List<Appointment>>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Appointment;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
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
				if (reader != null)
					reader.Close();
			}

            return appointments;
        }

        /// <summary>
        /// Updates the information from and appointment, in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be updated.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        /// <author>René Sørensen</author>
        public void UpdateAppointment(Appointment appointment, int estateAgentId)
        {
            int appointmentId = appointment.Id;

			SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE Ad SET EstateAgentId = (@estateAgentId), CustomerId = (@CustomerId), CaseId = (@CaseId), StartTimestamp = (@StartTimestamp), EndTimeStamp = (@EndTimeStamp), Description = (@Description), Place = (@Place)" + "WHERE AppointmentId = (@AppointmentId)"
            };

			cmd.Parameters.Add("@AppointmentId", SqlDbType.Int, 4, "AppointmentId").Value = appointmentId;

            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = estateAgentId;
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int, 4, "CustomerId").Value = appointment.Customer.Id;
            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = appointment.Case.Id;
            cmd.Parameters.Add("@StartTimestamp", SqlDbType.Date, 8, "StartTimestamp").Value = appointment.StartTimestamp;
            cmd.Parameters.Add("@EndTimeStamp", SqlDbType.Date, 8, "EndTimeStamp").Value = appointment.EndTimeStamp;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500, "Description").Value = appointment.Description;
            cmd.Parameters.Add("@Place", SqlDbType.NVarChar, 500, "Place").Value = appointment.Place;

            DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates an appointment in the database.
        /// </summary>
        /// <param name="appointment">Appointment to be created.</param>
        /// <param name="estateAgentId">EstateAgentId connected to the appointment</param>
        /// <returns>Returns the Id of the Appointment created.</returns>
        /// <author>René Sørensen</author>
        public int CreateAppointment(Appointment appointment, int estateAgentId)
        {
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "INSERT INTO Appointment OUTPUT INSERTED.AppointmentId VALUES (@EstateAgentId, @CustomerId, @CaseId, @StartTimestamp, @EndTimeStamp, @Description, @Place); "
            };

            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = estateAgentId;
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int, 4, "CustomerId").Value = appointment.Customer.Id;
            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = appointment.Case.Id;
            cmd.Parameters.Add("@StartTimestamp", SqlDbType.Date, 8, "StartTimestamp").Value = appointment.StartTimestamp;
            cmd.Parameters.Add("@EndTimeStamp", SqlDbType.Date, 8, "EndTimeStamp").Value = appointment.EndTimeStamp;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500, "Description").Value = appointment.Description;
            cmd.Parameters.Add("@Place", SqlDbType.NVarChar, 500, "Place").Value = appointment.Place;

			return (int)DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
