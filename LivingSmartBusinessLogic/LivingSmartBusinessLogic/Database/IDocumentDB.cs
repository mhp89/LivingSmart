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
        /// <summary>
        /// Returns a dictionary containing all the Documents in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the Documents in the database, with CaseId as key and a list of Documents containing that CaseId</returns>
        /// <author>René Sørensen</author>
        Dictionary<int, List<Document>> ReadDocuments();

        /// <summary>
        /// Returns all the ads from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the ads, having a CaseId given by the parameter</returns>
        /// <author>René Sørensen</author>
        List<Document> ReadDocuments(int caseId);

        /// <summary>
        /// Updates the information from a Document, in the database.
        /// </summary>
        /// <param name="document">Document to be updated.</param>
        /// <param name="caseId">CaseId connected to the Document</param>
        /// <author>René Sørensen</author>
        void UpdateDocument(Document document, int caseId);

        /// <summary>
        /// Creates a new Document in the database.
        /// </summary>
        /// <param name="document">Document to be created.</param>
        /// <param name="caseId">CaseId connected to the Document.</param>
        /// <returns>Returns the Id of the Document created.</returns>
        /// <author>René Sørensen</author>
        int CreateDocument(Document document, int caseId);

		/// <summary>
		/// Removes a document in the database.
		/// </summary>
		/// <param name="document">Document to be removed</param>
        /// <author>René Sørensen</author>
	    void DeleteDocument(Document document);
    }
}
