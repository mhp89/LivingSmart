using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IPictureDB
    {
        /// <summary>
        /// Returns all the Pictures from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the Pictures, having a CaseId given by the parameter</returns>
        List<Picture> ReadPictures(int caseId);

        /// <summary>
        /// Returns a dictionary containing all the Pictures in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the Pictures in the database, with CaseId as key and a list of Pictures containing that CaseId as value</returns>
        Dictionary<int, List<Picture>> ReadPictures();

        /// <summary>
        /// Updates the information from a Picture, in the database.
        /// </summary>
        /// <param name="picture">Picture to be updated.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        void UpdatePicture(Picture picture, int caseId);

        /// <summary>
        /// Creates a new Picture in the database.
        /// </summary>
        /// <param name="picture">Picture to be created.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        /// <returns>Returns the Id of the Picture created.</returns>
        int CreatePicture(Picture picture, int caseId);

		/// <summary>
		/// Removes a picture in the database.
		/// </summary>
		/// <param name="picture">Picture to be removed</param>
		void DeletePicture(Picture picture);
    }
}
