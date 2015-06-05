using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.DB;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    /// <summary>
    /// Dokumentkatalog
    /// </summary>
    /// <author>Mathias Poulsen</author>
    internal class DocumentCatalog
    {
        private Dictionary<int, List<Document>> documentDictionary;
        private IDocumentDB db;

        internal DocumentCatalog()
        {
            db = DocumentDBFactory.GetDBL();
            documentDictionary = new Dictionary<int, List<Document>>();

            LoadCatalog();
        }

        internal void LoadCatalog()
        {
            var documentList = db.ReadDocuments();
            foreach (var documents in documentList)
                foreach (var document in documents.Value)
                {
                    AddToCatalog(documents.Key, document);
                }
        }

        internal Document Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Document document, int caseId)
        {
            if (document.Id == -1)
                document.Id = db.CreateDocument(document, caseId);
            else
                db.UpdateDocument(document, caseId);
        }

        internal void AddToCatalog(int caseId, Document document)
        {
            if (!documentDictionary.ContainsKey(caseId))
                documentDictionary.Add(caseId, new List<Document>());
            documentDictionary[caseId].Add(document);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="estateAgentId"></param>
        /// <param name="document"></param>
        /// <author>Mathias Petersen</author>
        internal void RemoveFromCatalog(int estateAgentId, Document document)
        {
			db.DeleteDocument(document);
            documentDictionary[estateAgentId].Remove(document);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseId"></param>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
        internal ReadOnlyCollection<Document> GetDocuments(int caseId)
		{
			if (!documentDictionary.ContainsKey(caseId))
				return new ReadOnlyCollection<Document>(new List<Document>());

            return documentDictionary[caseId].AsReadOnly();
        }
    }
}
