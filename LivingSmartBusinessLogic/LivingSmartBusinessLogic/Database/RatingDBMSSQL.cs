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
    internal class RatingDBMSSQL : IRatingDB
    {
        /// <summary>
        /// Returns all the Ratings from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the Ratings, having a CaseId given by the parameter</returns>
        public List<Rating> ReadRatings(int caseId)
        {
            List<Rating> ratingList = new List<Rating>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Rating WHERE CaseID = " + caseId + ";",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ratingId = (int)reader["RatingId"];
                    long systemValue = (long)reader["SystemValue"];
                    long estateAgentValue = (long)reader["EstateAgentValue"];
                    DateTime date = (DateTime)reader["Date"];
                    int estateAgentId = (int)reader["EstateAgentId"];

                    Rating rating = new Rating(ratingId, estateAgentValue, systemValue, date, estateAgentId);
                    ratingList.Add(rating);
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

            return ratingList;
        }

        /// <summary>
        /// Returns a dictionary containing all the Ratings in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the Ratings in the database, with CaseId as key and a list of Ratings containing that CaseId as value</returns>
        public Dictionary<int, List<Rating>> ReadRatings()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the information from a Rating, in the database.
        /// </summary>
        /// <param name="rating">Rating to be updated.</param>
        /// <param name="caseId">CaseId connected to the Rating</param>
        /// <param name="estateAgentId">EstateAgentId connected to the Rating</param>
        public void UpdateRating(Rating rating, int caseId, int estateAgentId)
        {
            int ratingId = rating.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Rating SET CaseId = (@CaseId), SystemValue = (@SystemValue), EstateAgentValue = (@EstateAgentValue), Date = (@Date), EstateAgentId = (@EstateAgentId)" + "WHERE RatingId = " + ratingId
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@SystemValue", SqlDbType.BigInt, 8, "SystemValue").Value = rating.SystemValue;
            cmd.Parameters.Add("@EstateAgentValue", SqlDbType.BigInt, 8, "EstateAgentValue").Value = rating.EstateAgentValue;
            cmd.Parameters.Add("@Date", SqlDbType.Date, 8, "Date").Value = rating.Date;
            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = estateAgentId;

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
        /// Creates a new Rating in the database.
        /// </summary>
        /// <param name="rating">Rating to be created.</param>
        /// <param name="caseId">CaseId connected to the Rating</param>
        /// <param name="estateAgentId">EstateAgentId connected to the Rating</param>
        /// <returns>Returns the Id of the Rating created.</returns>
        public int CreateRating(Rating rating, int caseId, int estateAgentId)
        {
            int ratingId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Rating OUTPUT INSERTED.ID VALUES (@CaseId, @SystemValue, @EstateAgentValue, @Date, @EstateAgentId); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@SystemValue", SqlDbType.BigInt, 8, "SystemValue").Value = rating.SystemValue;
            cmd.Parameters.Add("@EstateAgentValue", SqlDbType.BigInt, 8, "EstateAgentValue").Value = rating.EstateAgentValue;
            cmd.Parameters.Add("@Date", SqlDbType.Date, 8, "Date").Value = rating.Date;
            cmd.Parameters.Add("@EstateAgentId", SqlDbType.Int, 4, "EstateAgentId").Value = estateAgentId;

            try
            {
                connection.Open();
                ratingId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return ratingId;
        }
    }
}
