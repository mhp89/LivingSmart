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
    internal class DistanceToDBMSSQL : IDistanceToDB
    {
        /// <summary>
        /// Returns a dictionary containing all the DistanceTos in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the DistanceTos in the database, with CaseId as key and a list of DistanceTos containing that CaseId</returns>
        public Dictionary<int, List<DistanceTo>> ReadDistanceTos()
        {
            Dictionary<int, List<DistanceTo>> distanceToDictionary = new Dictionary<int, List<DistanceTo>>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM DistanceTo;",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int distanceToId = (int)reader["DistanceToId"];
                    int caseId = (int)reader["CaseId"];
                    string type = (string)reader["Type"];
                    int distance = (int)reader["Distance"];

                    var distanceTo = new DistanceTo(distanceToId, type, distance);
                    if (!distanceToDictionary.ContainsKey(caseId))
                    {
                        distanceToDictionary.Add(caseId, new List<DistanceTo>());
                    }
                    distanceToDictionary[caseId].Add(distanceTo);
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

            return distanceToDictionary;
        }

        /// <summary>
        /// Returns all the ads from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the ads, having a CaseId given by the parameter</returns>
        public List<DistanceTo> ReadDistanceTos(int caseId)
        {
            var distanceToList = new List<DistanceTo>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM DistanceTo WHERE CaseId = " + caseId + ";",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int distanceToId = (int)reader["DistanceToId"];
                    string type = (string)reader["Type"];
                    int distance = (int)reader["Distance"];

                    var distanceTo = new DistanceTo(distanceToId, type, distance);
                    distanceToList.Add(distanceTo);
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

            return distanceToList;
        }

        /// <summary>
        /// Updates the information from a DistanceTo, in the database.
        /// </summary>
        /// <param name="distanceTo">DistanceTo to be updated.</param>
        /// <param name="caseId">CaseId connected to the DistanceTo.</param>
        public void UpdateDistanceTo(DistanceTo distanceTo, int caseId)
        {
            int distanceToId = distanceTo.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Ad SET CaseId = (@CaseId), Type = (@Type), Distance = (@Distance) WHERE DistanceToId = " + distanceToId
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.Char, 50, "Type").Value = distanceTo.Type;
            cmd.Parameters.Add("@Distance", SqlDbType.Int, 4, "Distance").Value = distanceTo.Distance;

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
        /// Creates a new DistanceTo in the database.
        /// </summary>
        /// <param name="distanceTo">DistanceTo to be created.</param>
        /// <param name="caseId">CaseId connected to the DistanceTo.</param>
        /// <returns>Returns the Id of the DistanceTo created.</returns>
        public int CreateDistanceTo(DistanceTo distanceTo, int caseId)
        {
            int appointmentId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
				CommandText = "INSERT INTO DistanceTo OUTPUT INSERTED.DistanceToId VALUES (@CaseId, @Type, @Distance); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.Char, 50, "Type").Value = distanceTo.Type;
            cmd.Parameters.Add("@Distance", SqlDbType.Int, 4, "Distance").Value = distanceTo.Distance;

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
