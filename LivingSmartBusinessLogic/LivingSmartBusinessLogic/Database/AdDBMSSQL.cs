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
    internal class AdDBMSSQL : IAdDB
    {
        /// <summary>
        /// Returns all the ads from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the ads, having a CaseId given by the parameter</returns>
        public List<Ad> ReadAds(int caseId)
        {
            List<Ad> adList = new List<Ad>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Ad WHERE CaseID = " + caseId + ";",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
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
            finally
            {
                connection.Close();
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
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Ad;",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
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
                connection.Close();
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

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Ad SET CaseId = (@CaseId), Type = (@Type), StartDate = (@StartDate), EndDate = (@EndDate), Price = (@Price)" + "WHERE AdId = " + adId
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "Name").Value = ad.Id;
            cmd.Parameters.Add("@Type", SqlDbType.Date, 8, "Name").Value = ad.Type;
            cmd.Parameters.Add("@StartDate", SqlDbType.Date, 8, "Name").Value = ad.StartDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.Date, 8, "Name").Value = ad.EndDate;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Name").Value = ad.Price;

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
        /// Creates a new Ad in the database.
        /// </summary>
        /// <param name="ad">Ad to be created.</param>
        /// <param name="caseId">CaseId connected to the ad.</param>
        /// <returns>Returns the Id of the Ad created.</returns>
        public int CreateAd(Ad ad, int caseId)
        {
            int adId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Ad OUTPUT INSERTED.AdId VALUES (@CaseId, @Type, @StartDate, @EndDate, @Price); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = ad.Type;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type").Value = ad.StartDate;
            cmd.Parameters.Add("@StartDate", SqlDbType.Date, 8, "StartDate").Value = ad.EndDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.Date, 8, "EndDate").Value = ad.Price;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Price").Value = ad.Id;

            try
            {
                connection.Open();
                adId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return adId;
        }
    }
}
