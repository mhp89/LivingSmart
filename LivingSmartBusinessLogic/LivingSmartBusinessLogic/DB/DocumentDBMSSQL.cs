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
        public List<Document> ReadDocuments()
        {
            throw new NotImplementedException();
        }

        public List<Document> ReadDocuments(int caseId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDocument(Document document, int caseId)
        {
            throw new NotImplementedException();
        }

        public int CreateDocument(Document document, int caseId)
        {
            throw new NotImplementedException();
        }
    }
}
