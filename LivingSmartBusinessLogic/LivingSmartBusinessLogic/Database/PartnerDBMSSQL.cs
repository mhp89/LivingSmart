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
        /// <summary>
        /// Returns all the Partners from the database.
        /// </summary>
        /// <returns>Returns a List of all the Partners from the database.</returns>
        /// <author>René Sørensen</author>
        public List<Partner> ReadPartners()
        {
            List<Partner> partnerList = new List<Partner>();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Partner;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
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
	            if (reader != null) 
					reader.Close();
            }

            return partnerList;
        }

        /// <summary>
        /// Updates the information from a Partner, in the database.
        /// </summary>
        /// <param name="partner">Partner to be updated.</param>
        /// <author>René Sørensen</author>
        public void UpdatePartner(Partner partner)
        {
            int partnerId = partner.Id;

            SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE Partner SET Name = (@Name), Telephone = (@Telephone), Email = (@Email), Country = (@Country), Region = (@Region), RegionShort = (@RegionShort), City = (@City), Timezone = (@Timezone) WHERE PartnerId = (@PartnerId)"
            };

			cmd.Parameters.Add("@PartnerId", SqlDbType.Int, 4, "PartnerId").Value = partnerId;

			cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name").Value = partner.Name;
			cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 20, "Telephone").Value = partner.Telephone;
			cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50, "Email").Value = partner.Email;
			cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 50, "Country").Value = partner.Country;
			cmd.Parameters.Add("@Region", SqlDbType.NVarChar, 50, "Region").Value = partner.Region;
            cmd.Parameters.Add("@RegionShort", SqlDbType.NVarChar, 4, "RegionShort").Value = partner.RegionShort;
			cmd.Parameters.Add("@City", SqlDbType.NVarChar, 50, "City").Value = partner.City;
			cmd.Parameters.Add("@Timezone", SqlDbType.NVarChar, 50, "Timezone").Value = partner.Timezone;

            DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new Partner in the database.
        /// </summary>
        /// <param name="partner">Partner to be created.</param>
        /// <returns>Returns the Id of the Partner created.</returns>
        /// <author>René Sørensen</author>
        public int CreatePartner(Partner partner)
        {
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "INSERT INTO Partner OUTPUT INSERTED.PartnerId VALUES (@Name, @Telephone, @Email, @Country, @Region, @RegionShort, @City, @Timezone); "
            };

			cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name").Value = partner.Name;
			cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 20, "Telephone").Value = partner.Telephone;
			cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50, "Email").Value = partner.Email;
			cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 50, "Country").Value = partner.Country;
			cmd.Parameters.Add("@Region", SqlDbType.NVarChar, 50, "Region").Value = partner.Region;
			cmd.Parameters.Add("@RegionShort", SqlDbType.NVarChar, 4, "RegionShort").Value = partner.RegionShort;
			cmd.Parameters.Add("@City", SqlDbType.NVarChar, 50, "City").Value = partner.City;
			cmd.Parameters.Add("@Timezone", SqlDbType.NVarChar, 50, "Timezone").Value = partner.Timezone;

	        return (int) DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
