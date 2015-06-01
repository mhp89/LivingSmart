using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IDocumentDB
    {
        Dictionary<int, List<Document>> ReadDocuments();
        List<Document> ReadDocuments(int caseId);
        void UpdateDocument(Document document, int caseId);
        int CreateDocument(Document document, int caseId);
    }
}
