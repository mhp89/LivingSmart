using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface IAdDB
    {
        /// <summary>
        /// Returns all the ads from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the ads, having a CaseId given by the parameter</returns>

        List<Ad> ReadAds(int caseId);

        /// <summary>
        /// Returns a dictionary containing all the ads in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the ads in the database, with CaseId as key and a list of Ads containing that CaseId</returns>
        Dictionary<int, List<Ad>> ReadAds();

        /// <summary>
        /// Updates the information from and ad, in the database.
        /// </summary>
        /// <param name="ad">Ad to be updated.</param>
        /// <param name="caseId">CaseId connected to the ad.</param>
        void UpdateAd(Ad ad, int caseId);

        /// <summary>
        /// Creates a new Ad in the database.
        /// </summary>
        /// <param name="ad">Ad to be created.</param>
        /// <param name="caseId">CaseId connected to the ad.</param>
        /// <returns>Returns the Id of the Ad created.</returns>
        int CreateAd(Ad ad, int caseId);
    }
}
