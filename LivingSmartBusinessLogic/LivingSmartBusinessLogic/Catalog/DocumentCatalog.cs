using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class DocumentCatalog
    {
        private Dictionary<int, List<Document>> documentDictionary;

        internal DocumentCatalog()
        {
            documentDictionary = new Dictionary<int, List<Document>>();
        }

        internal Document Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Document appointment)
        {
            throw new NotImplementedException();
        }

        internal void AddToCatalog(int caseId, Document document)
        {
            if (!documentDictionary.ContainsKey(caseId))
                documentDictionary.Add(caseId, new List<Document>());
            documentDictionary[caseId].Add(document);
        }

        internal void RemoveFromCatalog(int estateAgentId, Document document)
        {
            documentDictionary[estateAgentId].Remove(document);
        }

        internal ReadOnlyCollection<Document> GetDocuments(int caseId)
        {
            return documentDictionary[caseId].AsReadOnly();
        }
    }
}
