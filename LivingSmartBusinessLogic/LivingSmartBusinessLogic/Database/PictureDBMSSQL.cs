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
    internal class PictureDBMSSQL : IPictureDB
    {
        /// <summary>
        /// Returns all the Pictures from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the Pictures, having a CaseId given by the parameter</returns>
        public List<Picture> ReadPictures(int caseId)
        {
            List<Picture> pictureList = new List<Picture>();
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "SELECT * FROM Picture WHERE CaseId = (@CaseId);",
            };

			cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int pictureId = (int)reader["PictureId"];
                    string location = (string)reader["Location"];
                    string description = (string)reader["Description"];

                    Picture picture = new Picture(pictureId, location, description);
                    pictureList.Add(picture);
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

            return pictureList;
        }

        /// <summary>
        /// Returns a dictionary containing all the Pictures in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the Pictures in the database, with CaseId as key and a list of Pictures containing that CaseId as value</returns>
        public Dictionary<int, List<Picture>> ReadPictures()
        {
            Dictionary<int, List<Picture>> pictureDictionary = new Dictionary<int, List<Picture>>();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Picture;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int pictureId = (int)reader["PictureId"];
                    int caseId = (int)reader["CaseId"];
                    string location = (string)reader["Location"];
                    string description = reader["Description"] is DBNull ? null : (string)reader["Description"];
                    
                    Picture picture = new Picture(pictureId, location, description);
                    if (!pictureDictionary.ContainsKey(caseId))
                    {
                        pictureDictionary.Add(caseId, new List<Picture>());
                    }
                    pictureDictionary[caseId].Add(picture);
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

            return pictureDictionary;
        }

        /// <summary>
        /// Updates the information from a Picture, in the database.
        /// </summary>
        /// <param name="picture">Picture to be updated.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        public void UpdatePicture(Picture picture, int caseId)
        {
            int pictureId = picture.Id;

            SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE Picture SET CaseId = (@CaseId), Location = (@Location), Description = (@Description) WHERE PictureId = (@PictureId)"
            };

			cmd.Parameters.Add("@PictureId", SqlDbType.Int, 4, "PictureId").Value = pictureId;

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Location", SqlDbType.NVarChar, 200, "Location").Value = picture.Location;
			cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description").Value = (object)picture.Description ?? DBNull.Value;

	        DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new Picture in the database.
        /// </summary>
        /// <param name="picture">Picture to be created.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        /// <returns>Returns the Id of the Picture created.</returns>
        public int CreatePicture(Picture picture, int caseId)
        {
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "INSERT INTO Picture OUTPUT INSERTED.PictureId VALUES (@CaseId, @Location, @Description); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Location", SqlDbType.NVarChar, 200, "Location").Value = picture.Location;
			cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description").Value = (object)picture.Description ?? DBNull.Value;

	        return (int) DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }
    }
}
