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
    class AdDBMSSQL : IAdDB
    {
        public List<Ad> ReadAds()
        {
            List<Ad> adList = new List<Ad>();
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
                    int id = (int) reader["CustomerID"];
                    string name = (string) reader["Name"];
                    DateTime dateOfBirth = (DateTime) reader["DateOfBirth"];
                    string address = (string) reader["Address"];
                    int zipCode = (int) reader["ZipCode"];
                    string telephone = (string) reader["Telephone"];
                    string email = (string) reader["Email"];

                    Ad ad = new Ad();
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

        public void UpdateAd(Ad ad)
        {
            int adID = ad.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                // CommandText = "UPDATE CUSTOMER SET NAME = (@Name), DateOfBirth = (@DateOfBirth), Address = (@Address), ZipCode = (@ZipCode), Telephone = (@Telephone), Email = (@Email)" + "WHERE CustomerID = " + customerID
            };

            // cmd.Parameters.Add("@Name", SqlDbType.Char, 50, "Name").Value = customer.Name;
            // cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date, 50, "Name").Value = customer.DateOfBirth;

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

        public int CreateAd(Ad ad)
        {
            int customerID = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO CUSTOMER VALUES (@Name, @DateOfBirth, @Address, @ZipCode, @Telephone, @Email); " + "SELECT CAST(scope_identity() AS int);"
            };

//            cmd.Parameters.Add("@Name", SqlDbType.Char, 50, "Name").Value = customer.Name;
//            cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date, 50, "Name").Value = customer.DateOfBirth;

            try
            {
                connection.Open();
                customerID = (int) cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return customerID;
        }
    }
}
