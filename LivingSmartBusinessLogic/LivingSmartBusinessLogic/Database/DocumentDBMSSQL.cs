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
    internal class DocumentDBMSSQL : IDocumentDB
    {
        public Dictionary<int, List<Document>> ReadDocuments()
        {
            Dictionary<int, List<Document>> documentDictionary = new Dictionary<int, List<Document>>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Document;",
            };

	        SqlDataReader reader = null;
            try
            {
	            reader = DBConnectionMSSQL.Instance.ExecuteReader(cmd);
                while (reader.Read())
                {
                    int documentId = (int)reader["DocumentId"];
                    int caseId = (int)reader["CaseId"];
                    string type = (string)reader["Type"];
                    int price = (int)reader["Price"];
                    string location = (string)reader["Location"];

                    Document document = new Document(documentId, type, price, location);
                    if (!documentDictionary.ContainsKey(caseId))
                    {
                        documentDictionary.Add(caseId, new List<Document>());
                    }
                    documentDictionary[caseId].Add(document);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
				if(reader != null)
					reader.Close();
            }

            return documentDictionary;
        }

        /// <summary>
		/// Returns all the documents from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the documents, having a CaseId given by the parameter</returns>
        /// <author>René Sørensen</author>
        public List<Document> ReadDocuments(int caseId)
        {
            List<Document> documentList = new List<Document>();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM Document WHERE CaseID = (@CaseId);",
			};

			cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;

	        SqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int documentId = (int) reader["DocumentId"];
                    string type = (string) reader["Type"];
                    int price = (int) reader["Price"];
                    string location = (string) reader["Location"];

                    Document document = new Document(documentId, type, price, location);
                    documentList.Add(document);
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

            return documentList;
        }

        /// <summary>
        /// Updates the information from a Document, in the database.
        /// </summary>
        /// <param name="document">Document to be updated.</param>
        /// <param name="caseId">CaseId connected to the Document</param>
        /// <author>René Sørensen</author>
        public void UpdateDocument(Document document, int caseId)
        {
            int documentId = document.Id;

            SqlCommand cmd = new SqlCommand
            {
				CommandText = "UPDATE Document SET CaseId = (@CaseId), Type = (@Type), Price = (@Price), Location = (@Location) WHERE DocumentId = (@DocumentId)"
            };

			cmd.Parameters.Add("@DocumentId", SqlDbType.Int, 4, "DocumentId").Value = documentId;

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type").Value = document.Type;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Price").Value = document.Price;
            cmd.Parameters.Add("@Location", SqlDbType.NVarChar, 200, "Location").Value = document.Location;

            DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Creates a new Document in the database.
        /// </summary>
        /// <param name="document">Document to be created.</param>
        /// <param name="caseId">CaseId connected to the Document.</param>
        /// <returns>Returns the Id of the Document created.</returns>
        /// <author>René Sørensen</author>
        public int CreateDocument(Document document, int caseId)
        {
            SqlCommand cmd = new SqlCommand
            {
				CommandText = "INSERT INTO Document OUTPUT INSERTED.DocumentId VALUES (@CaseId, @Type, @Price, @Location); "
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type").Value = document.Type;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Price").Value = document.Price;
            cmd.Parameters.Add("@Location", SqlDbType.NVarChar, 200, "Location").Value = document.Location;

	        return (int) DBConnectionMSSQL.Instance.ExecuteScalar(cmd, -1);
        }

	    public void DeleteDocument(Document document)
	    {
		    SqlCommand cmd = new SqlCommand
		    {
			    CommandText = "DELETE FROM Document WHERE DocumentId = (@DocumentId)"
			};

			cmd.Parameters.Add("@DocumentId", SqlDbType.Int, 4, "DocumentId").Value = document.Id;

			DBConnectionMSSQL.Instance.ExecuteNonQuery(cmd);
	    }
    }
}
