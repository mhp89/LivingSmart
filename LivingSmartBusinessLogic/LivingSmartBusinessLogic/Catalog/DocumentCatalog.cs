using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    class DocumentCatalog
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

        internal void Save(Document document)
		{
			//if (document.Id == -1)
				//Create
			//else
				//Update
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
