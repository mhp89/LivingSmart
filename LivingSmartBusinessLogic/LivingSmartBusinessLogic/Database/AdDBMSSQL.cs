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
    internal class AdDBMSSQL : IAdDB
    {
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

        public void UpdateAd(Ad ad, int caseId)
        {
            int adID = ad.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Ad SET CaseId = (@CaseId), Type = (@Type), StartDate = (@StartDate), EndDate = (@EndDate), Price = (@Price)" + "WHERE AdId = " + adID
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 50, "Name").Value = ad.Id;
            cmd.Parameters.Add("@Type", SqlDbType.Date, 50, "Name").Value = ad.Type;
            cmd.Parameters.Add("@StartDate", SqlDbType.Date, 50, "Name").Value = ad.StartDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.Date, 50, "Name").Value = ad.EndDate;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 50, "Name").Value = ad.Price;

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

        public int CreateAd(Ad ad, int caseId)
        {
            int adId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Ad VALUES (@CaseId, @Type, @StartDate, @EndDate, @Price); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 50, "Name").Value = ad.Type;
            cmd.Parameters.Add("@Type", SqlDbType.Char, 50, "Name").Value = ad.StartDate;
            cmd.Parameters.Add("@StartDate", SqlDbType.Date, 50, "Name").Value = ad.EndDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.Date, 50, "Name").Value = ad.Price;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 50, "Name").Value = ad.Id;

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
