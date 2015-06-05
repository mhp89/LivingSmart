using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal class AdDBMSSQL : IAdDB
    {
        /// <summary>
        /// Returns all the ads from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the ads, having a CaseId given by the parameter</returns>
        /// <author>René Sørensen</author>
        public List<Ad> ReadAds(int caseId)
        {
            List<Ad> adList = new List<Ad>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Ad WHERE CaseID = " + caseId + ";",
            };

            try
            {
	            SqlDataReader reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int id = (int)reader["AdId"];
                    string type = (string)reader["Type"];
                    DateTime startDate = (DateTime)reader["StartDate"];
                    DateTime endDate = (DateTime)reader["EndDate"];
                    int price = (int)reader["Price"];

                    Ad ad = new Ad(id, type, startDate, endDate, price);
                    adList.Add(ad);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return adList;
        }

        /// <summary>
        /// Returns a dictionary containing all the ads in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the ads in the database, with CaseId as key and a list of Ads containing that CaseId</returns>
        public Dictionary<int, List<Ad>> ReadAds()
        {
            Dictionary<int, List<Ad>> adDictionary = new Dictionary<int, List<Ad>>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Ad;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int id = (int)reader["AdId"];
                    int caseId = (int)reader["CaseId"];
                    string type = (string)reader["Type"];
                    DateTime startDate = (DateTime)reader["StartDate"];
                    DateTime endDate = (DateTime)reader["EndDate"];
                    int price = (int)reader["Price"];

                    Ad ad = new Ad(id, type, startDate, endDate, price);
                    if (!adDictionary.ContainsKey(caseId))
                    {
                        adDictionary.Add(caseId, new List<Ad>());
                    }
                    adDictionary[caseId].Add(ad);
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

            return adDictionary;
        }

        /// <summary>
        /// Updates the information from and ad, in the database.
        /// </summary>
        /// <param name="ad">Ad to be updated.</param>
        /// <param name="caseId">CaseId connected to the ad.</param>
        public void UpdateAd(Ad ad, int caseId)
        {
            int adId = ad.Id;

            SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE Ad SET CaseId = (@CaseId), Type = (@Type), StartDate = (@StartDate), EndDate = (@EndDate), Price = (@Price)" + "WHERE AdId = (@AdId)"
            };

			cmd.Parameters.Add("@AdId", SqlDbType.Int, 4, "AdId").Value = adId;

			cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
			cmd.Parameters.Add("@Type", SqlDbType.Date, 8, "Type").Value = ad.Type;
			cmd.Parameters.Add("@StartDate", SqlDbType.Date, 8, "StartDate").Value = ad.StartDate;
			cmd.Parameters.Add("@EndDate", SqlDbType.Date, 8, "EndDate").Value = ad.EndDate;
			cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Price").Value = ad.Price;

			DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new Ad in the database.
        /// </summary>
        /// <param name="ad">Ad to be created.</param>
        /// <param name="caseId">CaseId connected to the ad.</param>
        /// <returns>Returns the Id of the Ad created.</returns>
        public int CreateAd(Ad ad, int caseId)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "INSERT INTO Ad OUTPUT INSERTED.AdId VALUES (@CaseId, @Type, @StartDate, @EndDate, @Price); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = ad.Type;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type").Value = ad.StartDate;
            cmd.Parameters.Add("@StartDate", SqlDbType.Date, 8, "StartDate").Value = ad.EndDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.Date, 8, "EndDate").Value = ad.Price;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Price").Value = ad.Id;

			return (int)DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
