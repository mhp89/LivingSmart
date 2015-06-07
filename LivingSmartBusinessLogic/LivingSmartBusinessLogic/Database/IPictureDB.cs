using System.Collections.Generic;
using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface IPictureDB
    {
        /// <summary>
        /// Returns all the Pictures from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the Pictures, having a CaseId given by the parameter</returns>
        /// <author>Ren� S�rensen</author>
        List<Picture> ReadPictures(int caseId);

        /// <summary>
        /// Returns a dictionary containing all the Pictures in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the Pictures in the database, with CaseId as key and a list of Pictures containing that CaseId as value</returns>
        /// <author>Ren� S�rensen</author>
        Dictionary<int, List<Picture>> ReadPictures();

        /// <summary>
        /// Updates the information from a Picture, in the database.
        /// </summary>
        /// <param name="picture">Picture to be updated.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        /// <author>Ren� S�rensen</author>
        void UpdatePicture(Picture picture, int caseId);

        /// <summary>
        /// Creates a new Picture in the database.
        /// </summary>
        /// <param name="picture">Picture to be created.</param>
        /// <param name="caseId">CaseId connected to the Picture</param>
        /// <returns>Returns the Id of the Picture created.</returns>
        /// <author>Ren� S�rensen</author>
        int CreatePicture(Picture picture, int caseId);

		/// <summary>
		/// Removes a picture from the database.
		/// </summary>
		/// <param name="picture">Picture to be removed</param>
        /// <author>Ren� S�rensen</author>
		void DeletePicture(Picture picture);
    }
}
