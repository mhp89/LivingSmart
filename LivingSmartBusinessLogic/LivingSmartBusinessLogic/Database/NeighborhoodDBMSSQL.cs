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
    internal class NeighborhoodDBMSSQL : INeighborhoodDB
    {
        /// <summary>
        /// Returns all the Neighborhoods from the database.
        /// </summary>
        /// <returns>Returns a List of all the Neighborhoods from the database.</returns>
        public List<Neighborhood> ReadNeighborhoods()
        {
            List<Neighborhood> neighborhoodList = new List<Neighborhood>();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Neighborhood;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int zipCode = (int)reader["ZipCoded"];
                    string name = (string)reader["Neighborhood"];
                    int value = (int)reader["Value"];

                    Neighborhood neighborhood = new Neighborhood(zipCode, name, value);
                    neighborhoodList.Add(neighborhood);
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

            return neighborhoodList;
        }

        /// <summary>
        /// Updates the information from a Neighborhood, in the database.
        /// </summary>
        /// <param name="neighborhood">Neighborhood to be updated.</param>
        public void UpdateNeighborhood(Neighborhood neighborhood)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "UPDATE Neighborhood SET Value = (@Value) WHERE ZipCode = (@ZipCode) AND Neighborhood  = (@Neighborhood)"
            };

            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 4, "ZipCode").Value = neighborhood.ZipCode;
            cmd.Parameters.Add("@Neighborhood", SqlDbType.NVarChar, 15, "Neighborhood").Value = neighborhood.Name;
            cmd.Parameters.Add("@Value", SqlDbType.Date, 8, "Value").Value = neighborhood.Value;

            DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new Neighborhood in the database.
        /// </summary>
        /// <param name="neighborhood">Neighborhood to be created.</param>
        /// <returns>Returns the Id of the Neighborhood created.</returns>
        public int CreateNeighborhood(Neighborhood neighborhood)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "INSERT INTO Neighborhood OUTPUT INSERTED.Id VALUES (@ZipCode, @Neighborhood, @Value); "
            };

            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 50, "ZipCode").Value = neighborhood.City.ZipCode;
            cmd.Parameters.Add("@Neighborhood", SqlDbType.NVarChar, 15, "Neighborhood").Value = neighborhood.Name;
            cmd.Parameters.Add("@Value", SqlDbType.Date, 8, "Value").Value = neighborhood.Value;

	        return (int) DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
