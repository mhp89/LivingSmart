using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    interface IDocumentDB
    {
        List<Document> ReadDocuments();
        void UpdateDocument(Document document);
        int CreateDocument(Document document);
    }
}
