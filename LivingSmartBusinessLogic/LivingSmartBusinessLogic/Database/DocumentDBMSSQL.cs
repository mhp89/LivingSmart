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
    internal class DocumentDBMSSQL : IDocumentDB
    {
        public Dictionary<int, List<Document>> ReadDocuments()
        {
            Dictionary<int, List<Document>> documentDictionary = new Dictionary<int, List<Document>>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Document;",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int documentId = (int)reader["DocumentId"];
                    int caseId = (int)reader["CaseId"];
                    string type = (string)reader["Type"];
                    int price = (int)reader["Price"];
                    string location = (string)reader["Location"];
                    string status = (string)reader["Status"];

                    Document document = new Document(documentId, type, price, location, status);
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
                connection.Close();
            }

            return documentDictionary;
        }

        public List<Document> ReadDocuments(int caseId)
        {
            List<Document> documentList = new List<Document>();
            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM Document WHERE CaseID = " + caseId + ";",
            };

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int documentId = (int) reader["DocumentId"];
                    string type = (string) reader["Type"];
                    int price = (int) reader["Price"];
                    string location = (string) reader["Location"];
                    string status = (string) reader["Status"];

                    Document document = new Document(documentId, type, price, location, status);
                    documentList.Add(document);
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

            return documentList;
        }

        public void UpdateDocument(Document document, int caseId)
        {
            int documentId = document.Id;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "UPDATE Document SET CaseId = (@CaseId), Type = (@Type), Price = (@Price), Location = (@Location), Status = (@Status)" + "WHERE DocumentId = " + documentId
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.Char, 50, "Type").Value = document.Type;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Price").Value = document.Price;
            cmd.Parameters.Add("@Location", SqlDbType.Char, 100, "Location").Value = document.Location;
            cmd.Parameters.Add("@Status", SqlDbType.Char, 50, "Status").Value = document.Status;

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

        public int CreateDocument(Document document, int caseId)
        {
            int adId = 0;

            SqlConnection connection = DBConnectionMSSQL.Instance.GetDBConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Document VALUES (@CaseId, @Type, @Price, @Location, @Status); " + "SELECT CAST(scope_identity() AS int);"
            };

            cmd.Parameters.Add("@CaseId", SqlDbType.Int, 4, "CaseId").Value = caseId;
            cmd.Parameters.Add("@Type", SqlDbType.Char, 50, "Type").Value = document.Type;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4, "Price").Value = document.Price;
            cmd.Parameters.Add("@Location", SqlDbType.Char, 100, "Location").Value = document.Location;
            cmd.Parameters.Add("@Status", SqlDbType.Char, 50, "Status").Value = document.Status;

            try
            {
                connection.Open();
                adId = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return adId;
        }
    }
}
