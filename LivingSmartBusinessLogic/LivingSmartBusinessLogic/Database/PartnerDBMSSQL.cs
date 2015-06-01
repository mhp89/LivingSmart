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
    internal class PartnerDBMSSQL : IPartnerDB
    {
        public List<Partner> ReadPartners()
        {
            List<Partner> partnerList = new List<Partner>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Partner;",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int partnerId = (int)reader["PartnerId"];
                    string name = (string)reader["Name"];
                    string telephone = (string)reader["Telephone"];
                    string email = (string)reader["Email"];
                    string country = (string)reader["Country"];
                    string region = (string)reader["Region"];
                    string regionShort = (string)reader["RegionShort"];
                    string city = (string)reader["City"];
                    string timezone = (string)reader["Timezone"];

                    Partner partner = new Partner(partnerId, name, telephone, email, country, city, region, regionShort, timezone);
                    partnerList.Add(partner);
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

            return partnerList;
        }

        public void UpdatePartner(Partner partner)
        {
            int partnerId = partner.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Partner SET Name = (@Name), Telephone = (@Telephone), Email = (@Email), Country = (@Country), Region = (@Region), RegionShort = (@RegionShort), City = (@City), Timezone = (@Timezone)" + "WHERE PartnerId = " + partnerId
            };

            cmd.Parameters.Add("@Name", SqlDbType.Char, 50, "Name").Value = partner.Name;
            cmd.Parameters.Add("@Telephone", SqlDbType.Char, 20, "Telephone").Value = partner.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.Char, 50, "Email").Value = partner.Email;
            cmd.Parameters.Add("@Country", SqlDbType.Char, 50, "Country").Value = partner.Country;
            cmd.Parameters.Add("@Region", SqlDbType.Char, 50, "Region").Value = partner.Region;
            cmd.Parameters.Add("@RegionShort", SqlDbType.Char, 50, "RegionShort").Value = partner.RegionShort;
            cmd.Parameters.Add("@City", SqlDbType.Char, 4, "City").Value = partner.City;
            cmd.Parameters.Add("@Timezone", SqlDbType.Char, 50, "Timezone").Value = partner.Timezone;

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

        public int CreatePartner(Partner partner)
        {
            int partnerId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Partner VALUES (@Name, @Telephone, @Email, @Country, @Region, @RegionShort, @City, @Timezone); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@Name", SqlDbType.Char, 50, "Name").Value = partner.Name;
            cmd.Parameters.Add("@Telephone", SqlDbType.Char, 20, "Telephone").Value = partner.Telephone;
            cmd.Parameters.Add("@Email", SqlDbType.Char, 50, "Email").Value = partner.Email;
            cmd.Parameters.Add("@Country", SqlDbType.Char, 50, "Country").Value = partner.Country;
            cmd.Parameters.Add("@Region", SqlDbType.Char, 50, "Region").Value = partner.Region;
            cmd.Parameters.Add("@RegionShort", SqlDbType.Char, 50, "RegionShort").Value = partner.RegionShort;
            cmd.Parameters.Add("@City", SqlDbType.Char, 4, "City").Value = partner.City;
            cmd.Parameters.Add("@Timezone", SqlDbType.Char, 50, "Timezone").Value = partner.Timezone;

            try
            {
                connection.Open();
                partnerId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return partnerId;
        }
    }
}
