using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal class AskingPriceDBMSSQL : IAskingPriceDB
    {
        /// <summary>
        /// Returns a dictionary containing all the AskingPrices in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the AskingPrices in the database, with CaseId as key and a list of AskingPrices containing that caseId</returns>
        /// <author>Ren� S�rensen</author>
        public Dictionary<int, List<AskingPrice>> ReadAskingPrices()
        {
            Dictionary<int, List<AskingPrice>> askingPriceList = new Dictionary<int, List<AskingPrice>>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM AskingPrice ORDER BY Date ASC;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int askingPriceId = (int)reader["AskingPriceId"];
                    int caseId = (int) reader["CaseId"];
                    long value = (long)reader["Value"];
                    DateTime date = (DateTime)reader["Date"];

                    AskingPrice askingPrice = new AskingPrice(askingPriceId, value, date);
                    if (!askingPriceList.ContainsKey(caseId))
                    {
                        askingPriceList.Add(caseId, new List<AskingPrice>());
                    }

                    askingPriceList[caseId].Add(askingPrice);
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

            return askingPriceList;
        }

        /// <summary>
        /// Updates the information from an AskingPrice, in the database.
        /// </summary>
        /// <param name="askingPrice">AskingPrice to be updated.</param>
        /// <param name="caseId">CaseId connected to the appointment</param>
        /// <author>Ren� S�rensen</author>
        public void UpdateAskingPrice(AskingPrice askingPrice, int caseId)
        {
            int askingPriceId = askingPrice.Id;

            SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE AskingPrice SET CaseId = (@CaseId), Value = (@Value), Date = (@Date)" + "WHERE AskingPriceId = (@AskingPriceId)"
            };

			cmd.Parameters.Add("@AskingPriceId", SqlDbType.Int, 4, "AskingPriceId").Value = askingPriceId;

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "caseId").Value = caseId;
            cmd.Parameters.Add("@Value", SqlDbType.BigInt, 8, "Value").Value = askingPrice.Value;
            cmd.Parameters.Add("@Date", SqlDbType.Date, 8, "Date").Value = askingPrice.Date;

			DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates an AskingPrice in the database.
        /// </summary>
        /// <param name="askingPrice">AskingPrice to be created.</param>
        /// <param name="caseId">CaseId connected to the AskingPrice</param>
        /// <returns>Returns the Id of the AskingPrice created.</returns>
        /// <author>Ren� S�rensen</author>
        public int CreateAskingPrice(AskingPrice askingPrice, int caseId)
        {
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "INSERT INTO AskingPrice OUTPUT INSERTED.AskingPriceId VALUES (@CaseId, @Value, @Date); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "caseId").Value = caseId;
            cmd.Parameters.Add("@Value", SqlDbType.BigInt, 8, "Value").Value = askingPrice.Value;
            cmd.Parameters.Add("@Date", SqlDbType.Date, 8, "Date").Value = askingPrice.Date;

			return (int)DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
