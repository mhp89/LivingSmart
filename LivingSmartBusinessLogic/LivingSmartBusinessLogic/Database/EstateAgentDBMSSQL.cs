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
    internal class EstateAgentDBMSSQL : IEstateAgentDB
    {
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
                    DateTime terminationDate = (DateTime)reader["StartingDate"];

                    EstateAgent estateAgent = new EstateAgent(estateAgentId, name, telephone, email, startingDate, terminationDate);
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
            cmd.Parameters.Add("@StartingDate", SqlDbType.Date, 50, "StartingDate").Value = estateAgent.StartingDate;
            cmd.Parameters.Add("@TerminationDate", SqlDbType.Date, 50, "TerminationDate").Value = estateAgent.TerminationDate;

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

        public int CreateEstateAgent(EstateAgent estateAgent)
        {
            int estateagentId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO EstateAgent VALUES (@Name, @Telephone, @Email, @StartingDate, @TerminationDate); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@Name", SqlDbType.Char, 50, "Name").Value = estateAgent.Name;
            cmd.Parameters.Add("@Telephone", SqlDbType.Char, 20, "Telephone").Value = estateAgent.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.Char, 50, "Email").Value = estateAgent.Email;
            cmd.Parameters.Add("@StartingDate", SqlDbType.Date, 50, "StartingDate").Value = estateAgent.StartingDate;
            cmd.Parameters.Add("@TerminationDate", SqlDbType.Date, 50, "TerminationDate").Value = estateAgent.TerminationDate;

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
    }
}
