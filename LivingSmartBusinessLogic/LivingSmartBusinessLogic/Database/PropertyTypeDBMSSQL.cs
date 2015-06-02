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
    internal class PropertyTypeDBMSSQL : IPropertyTypeDB
    {
        /// <summary>
        /// Returns all the PropertyTypes from the database.
        /// </summary>
        /// <returns>Returns a List of all the PropertyTypes.</returns>
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

        /// <summary>
        /// Updates the information from a PropertyType, in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be updated.</param>
        public void UpdatePropertyType(PropertyType propertyType)
        {
            int propertyTypeId = propertyType.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE PropertyType SET Description = (@Description) WHERE AppointmentId = " + propertyTypeId
            };

            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50, "Description").Value = propertyType.Description;

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
        /// Creates a new PropertyType in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be created.</param>
        /// <returns>Returns the Id of the PropertyType created.</returns>
        public int CreatePropertyType(PropertyType propertyType)
        {
            int propertyTypeId = -1;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
				CommandText = "INSERT INTO PropertyType OUTPUT INSERTED.PropertyTypeId VALUES (@CaseId, @Type, @StartDate, @EndDate, @Price); "
            };

            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50, "Description").Value = propertyType.Description;

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
