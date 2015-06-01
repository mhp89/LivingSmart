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
    internal class AskingPriceDBMSSQL : IAskingPriceDB
    {
        /// <summary>
        /// Returns all the AskingPrices from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the AskingPrices, having a CaseId given by the parameter</returns>
        public List<AskingPrice> ReadAskingPrices(int caseId)
        {
            List<AskingPrice> askingPriceList = new List<AskingPrice>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM AskingPrice WHERE caseId = " + caseId + ";",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int askingPriceId = (int)reader["AskingPriceId"];
                    long value = (long)reader["Value"];
                    DateTime date = (DateTime)reader["Date"];

                    AskingPrice askingPrice = new AskingPrice(askingPriceId, value, date);
                    askingPriceList.Add(askingPrice);
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

            return askingPriceList;
        }

        /// <summary>
        /// Updates the information from and AskingPrice, in the database.
        /// </summary>
        /// <param name="askingPrice">AskingPrice to be updated.</param>
        /// <param name="caseId">CaseId connected to the ad</param>
        public void UpdateAskingPrice(AskingPrice askingPrice, int caseId)
        {
            int askingPriceId = askingPrice.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE AskingPrice SET CaseId = (@CaseId), Value = (@Value), Date = (@Date)" + "WHERE AskingPriceId = " + askingPriceId
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "caseId").Value = caseId;
            cmd.Parameters.Add("@Value", SqlDbType.BigInt, 8, "Value").Value = askingPrice.Value;
            cmd.Parameters.Add("@Date", SqlDbType.Date, 8, "Date").Value = askingPrice.Date;

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
        /// Creates a new AskingPrice in the database.
        /// </summary>
        /// <param name="askingPrice">AskingPrice to be created.</param>
        /// <param name="caseId">CaseId connected to the AskingPrice.</param>
        /// <returns>Returns the Id of the AskingPrice created.</returns>
        public int CreateAskingPrice(AskingPrice askingPrice, int caseId)
        {
            int askingPriceId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO AskingPrice OUTPUT INSERTED.ID VALUES (@CaseId, @Value, @Date); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "caseId").Value = caseId;
            cmd.Parameters.Add("@Value", SqlDbType.BigInt, 8, "Value").Value = askingPrice.Value;
            cmd.Parameters.Add("@Date", SqlDbType.Date, 8, "Date").Value = askingPrice.Date;

            try
            {
                connection.Open();
                askingPriceId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return askingPriceId;
        }
    }
}
