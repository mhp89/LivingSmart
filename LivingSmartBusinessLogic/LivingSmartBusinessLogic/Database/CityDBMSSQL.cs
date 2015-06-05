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
    internal class CityDBMSSQL : ICityDB
    {
        /// <summary>
        /// Returns all the Cities from the database.
        /// </summary>
        /// <returns>Returns a List of all the Cities from the database</returns>
        /// <author>René Sørensen</author>
        public List<City> ReadCities()
        {
            List<City> cityList = new List<City>();
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "SELECT * FROM ZipCode;"
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int zipCode = (int)reader["ZipCode"];
                    string district = (string)reader["District"];

                    City city = new City(zipCode, district);
                    cityList.Add(city);
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

            return cityList;
        }
    }
}
