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
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Picture WHERE CaseId = " + caseId + ";",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
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
                connection.Close();
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
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Picture;",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int pictureId = (int)reader["PictureId"];
                    int caseId = (int)reader["CaseId"];
                    string location = (string)reader["Location"];
                    string description = (string)reader["Description"];

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
                connection.Close();
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

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Picture SET CaseId = (@CaseId), Location = (@Location), Description = (@Description) WHERE PictureId = " + pictureId
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Location", SqlDbType.Date, 8, "Location").Value = picture.Location;
            cmd.Parameters.Add("@Description", SqlDbType.Date, 8, "Description").Value = picture.Desription;

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
        /// Creates a new Picture in the database.
        /// </summary>
        /// <param name="picture">Picture to be created.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        /// <returns>Returns the Id of the Picture created.</returns>
        public int CreatePicture(Picture picture, int caseId)
        {
            int pictureId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Picture OUTPUT INSERTED.ID VALUES (@CaseId, @Location, @Description); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Location", SqlDbType.Date, 8, "Location").Value = picture.Location;
            cmd.Parameters.Add("@Description", SqlDbType.Date, 8, "Description").Value = picture.Desription;

            try
            {
                connection.Open();
                pictureId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return pictureId;
        }
    }
}
