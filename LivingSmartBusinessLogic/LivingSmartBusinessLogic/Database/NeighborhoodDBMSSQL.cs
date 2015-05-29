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
    internal class NeighborhoodDBMSSQL : INeighborhoodDB
    {
        public List<Neighborhood> ReadNeighborhoods()
        {
            throw new NotImplementedException();
        }

        public void UpdateNeighborhood(Neighborhood neighborhood)
        {
            throw new NotImplementedException();
        }

        public int CreateNeighborhood(Neighborhood neighborhood)
        {
            int neighborhoodId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Neighborhood VALUES (@ZipCode, @Neighborhood, @Value); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@ZipCode", SqlDbType.Int, 50, "ZipCode").Value = neighborhood.City.ZipCode;
            cmd.Parameters.Add("@Neighborhood", SqlDbType.Char, 50, "Neighborhood").Value = neighborhood.Name;
            cmd.Parameters.Add("@Value", SqlDbType.Date, 50, "Value").Value = neighborhood.Value;

            try
            {
                connection.Open();
                neighborhoodId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return neighborhoodId;
        }
    }
}
