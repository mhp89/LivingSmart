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
    internal class EstateAgentDBMSSQL : IEstateAgentDB
    {
        /// <summary>
        /// Returns all the EstateAgents from the database.
        /// </summary>
        /// <returns>Returns a List of all the EstateAgents from the database.</returns>
        public List<EstateAgent> ReadEstateAgents()
        {
            List<EstateAgent> estateAgentList = new List<EstateAgent>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM EstateAgent;",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int estateAgentId = (int)reader["EstateAgentId"];
                    string name = (string)reader["Name"];
                    string telephone = (string)reader["Telephone"];
                    string email = (string)reader["Email"];
                    DateTime startingDate = (DateTime)reader["StartingDate"];
					DateTime? terminationDate = (reader["TerminationDate"].GetType() == typeof(DBNull)) ? null : (DateTime?)reader["TerminationDate"];
					string username = (string)reader["Username"];
					string password = (string)reader["Password"];

                    EstateAgent estateAgent = new EstateAgent(estateAgentId, name, telephone, email, startingDate, terminationDate, username, password);
                    estateAgentList.Add(estateAgent);
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

            return estateAgentList;
        }

        /// <summary>
        /// Updates the information from an EstateAgent, in the database.
        /// </summary>
        /// <param name="estateAgent">EstateAgent to be updated.</param>
        public void UpdateEstateAgent(EstateAgent estateAgent)
        {
            int estateagentId = estateAgent.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE EstateAgent SET Name = (@Name), Telephone = (@Telephone), Email = (@Email), StartingDate = (@StartingDate), TerminationDate = (@TerminationDate)" + "WHERE EstateAgentId = " + estateagentId
            };

            cmd.Parameters.Add("@Name", SqlDbType.Char, 50, "Name").Value = estateAgent.Name;
            cmd.Parameters.Add("@Telephone", SqlDbType.Char, 20, "Telephone").Value = estateAgent.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.Char, 50, "Email").Value = estateAgent.Email;
            cmd.Parameters.Add("@StartingDate", SqlDbType.Date, 8, "StartingDate").Value = estateAgent.StartingDate;
			cmd.Parameters.Add("@TerminationDate", SqlDbType.Date, 8, "TerminationDate").Value = (object)estateAgent.TerminationDate ?? DBNull.Value;

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
        /// Creates a new EstateAgent in the database.
        /// </summary>
        /// <param name="estateAgent">EstateAgent to be created.</param>
        /// <returns>Returns the Id of the EstateAgent created.</returns>
        public int CreateEstateAgent(EstateAgent estateAgent)
        {
            int estateagentId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
				CommandText = "INSERT INTO EstateAgent OUTPUT INSERTED.EstateAgentId VALUES (@Name, @Telephone, @Email, @StartingDate, @TerminationDate, @Username, @Password); "
            };

            cmd.Parameters.Add("@Name", SqlDbType.Char, 50, "Name").Value = estateAgent.Name;
            cmd.Parameters.Add("@Telephone", SqlDbType.Char, 20, "Telephone").Value = estateAgent.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.Char, 50, "Email").Value = estateAgent.Email;
            cmd.Parameters.Add("@StartingDate", SqlDbType.Date, 8, "StartingDate").Value = estateAgent.StartingDate;
			cmd.Parameters.Add("@TerminationDate", SqlDbType.Date, 8, "TerminationDate").Value = (object)estateAgent.TerminationDate ?? DBNull.Value;
			cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username").Value = estateAgent.Username;
			cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50, "Password").Value = estateAgent.Password;

            try
            {
                connection.Open();
                estateagentId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return estateagentId;
        }

	    public EstateAgent LoginEstateAgent(string username, string password)
	    {
		    EstateAgent estateAgent = null;
			SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
			SqlCommand cmd = new SqlCommand
			{
				Connection = connection,
				CommandText = "SELECT * FROM EstateAgent WHERE Username = (@Username) AND Password = (@Password);",
			};

			cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 15, "Username").Value = username;
			cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 25, "Password").Value = password;

			try
			{
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int readEstateAgentId = (int)reader["EstateAgentId"];
					string name = (string)reader["Name"];
					string telephone = (string)reader["Telephone"];
					string email = (string)reader["Email"];
					DateTime startingDate = (DateTime)reader["StartingDate"];
					DateTime? terminationDate = (reader["TerminationDate"].GetType() == typeof(DBNull)) ? null : (DateTime?)reader["TerminationDate"];
					string usernameData = (string)reader["Username"];
					string passwordData = (string)reader["Password"];

					estateAgent = new EstateAgent(readEstateAgentId, name, telephone, email, startingDate, terminationDate, usernameData, passwordData);
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

			return estateAgent;
	    }
    }
}
