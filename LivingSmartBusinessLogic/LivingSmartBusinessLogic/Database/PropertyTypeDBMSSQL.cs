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
    internal class PropertyTypeDBMSSQL : IPropertyTypeDB
    {
        public List<PropertyType> ReadPropertyTypes()
        {
            List<PropertyType> propertyTypeList = new List<PropertyType>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM PropertyType WHERE Deleted = 'FALSE';"
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int propertyTypeId = (int)reader["PropertyTypeId"];
                    string description = (string)reader["Description"];

                    PropertyType propertyType = new PropertyType(propertyTypeId, description);
                    propertyTypeList.Add(propertyType);
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

            return propertyTypeList;
        }

        public void UpdatePropertyType(PropertyType propertyType)
        {
            int propertyTypeId = propertyType.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE PropertyType SET Description = (@Description) WHERE AppointmentId = " + propertyTypeId
            };

            cmd.Parameters.Add("@Description", SqlDbType.Char, 50, "Description").Value = propertyType.Description;

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
        public int CreatePropertyType(PropertyType propertyType)
        {
            int propertyTypeId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO PropertyType VALUES (@CaseId, @Type, @StartDate, @EndDate, @Price); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@Description", SqlDbType.Char, 50, "Description").Value = propertyType.Description;

            try
            {
                connection.Open();
                propertyTypeId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return propertyTypeId;
        }
    }
}