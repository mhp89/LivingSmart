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
    internal class DistanceToDBMSSQL : IDistanceToDB
    {
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

        public void UpdateDistanceTo(DistanceTo distanceTo, int caseId)
        {
            int distanceToId = distanceTo.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Ad SET CaseId = (@CaseId), Type = (@Type), Distance = (@Distance) WHERE DistanceToId = " + distanceToId
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 50, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.Char, 50, "Type").Value = distanceTo.Type;
            cmd.Parameters.Add("@Distance", SqlDbType.Int, 50, "Distance").Value = distanceTo.Distance;

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

        public int CreateDistanceTo(DistanceTo distanceTo, int caseId)
        {
            int appointmentId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO DistanceTo VALUES (@CaseId, @Type, @Distance); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 50, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.Char, 50, "Type").Value = distanceTo.Type;
            cmd.Parameters.Add("@Distance", SqlDbType.Int, 50, "Distance").Value = distanceTo.Distance;

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
