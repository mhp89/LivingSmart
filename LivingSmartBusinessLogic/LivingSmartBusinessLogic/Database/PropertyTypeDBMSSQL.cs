using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal class PropertyTypeDBMSSQL : IPropertyTypeDB
    {
        /// <summary>
        /// Returns all the PropertyTypes from the database.
        /// </summary>
        /// <returns>Returns a List of all the PropertyTypes.</returns>
        /// <author>Ren� S�rensen</author>
        public List<PropertyType> ReadPropertyTypes()
        {
            List<PropertyType> propertyTypeList = new List<PropertyType>();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM PropertyType WHERE Deleted = 'FALSE';"
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int propertyTypeId = (int)reader["PropertyTypeId"];
                    string description = (string)reader["Description"];
                    bool deleted = (bool) reader["Deleted"];

                    PropertyType propertyType = new PropertyType(propertyTypeId, description, deleted);
                    propertyTypeList.Add(propertyType);
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

            return propertyTypeList;
        }

        /// <summary>
        /// Updates the information from a PropertyType, in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be updated.</param>
        /// <author>Ren� S�rensen</author>
        public void UpdatePropertyType(PropertyType propertyType)
        {
            int propertyTypeId = propertyType.Id;

            SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE PropertyType SET Description = (@Description), Deleted = (@Deleted) WHERE PropertyTypeId = (@PropertyTypeId)"
            };

			cmd.Parameters.Add("@PropertyTypeId", SqlDbType.Int, 4, "PropertyTypeId").Value = propertyTypeId;

			cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50, "Description").Value = propertyType.Description;
			//TODO: ENABLE cmd.Parameters.Add("@Deleted", SqlDbType.Bit, 1, "Deleted").Value = propertyType.Deleted;

	        DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new PropertyType in the database.
        /// </summary>
        /// <param name="propertyType">PropertyType to be created.</param>
        /// <returns>Returns the Id of the PropertyType created.</returns>
        /// <author>Ren� S�rensen</author>
        public int CreatePropertyType(PropertyType propertyType)
        {
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "INSERT INTO PropertyType OUTPUT INSERTED.PropertyTypeId VALUES (@Description); "
            };

            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50, "Description").Value = propertyType.Description;

	        return (int) DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
