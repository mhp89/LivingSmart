using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IDistanceToDB
    {
        /// <summary>
        /// Returns a dictionary containing all the DistanceTos in the database.
        /// </summary>
        /// <returns>Returns a dictionary containing all the DistanceTos in the database, with CaseId as key and a list of DistanceTos containing that CaseId</returns>
        /// <author>René Sørensen</author>
        Dictionary<int, List<DistanceTo>> ReadDistanceTos();

        /// <summary>
        /// Returns all the ads from the database, with a given CaseId.
        /// </summary>
        /// <param name="caseId">Id of the case</param>
        /// <returns>Returns a List of all the ads, having a CaseId given by the parameter</returns>
        /// <author>René Sørensen</author>
        List<DistanceTo> ReadDistanceTos(int caseId);

        /// <summary>
        /// Updates the information from a DistanceTo, in the database.
        /// </summary>
        /// <param name="distanceTo">DistanceTo to be updated.</param>
        /// <param name="caseId">CaseId connected to the DistanceTo.</param>
        /// <author>René Sørensen</author>
        void UpdateDistanceTo(DistanceTo distanceTo, int caseId);

        /// <summary>
        /// Creates a new DistanceTo in the database.
        /// </summary>
        /// <param name="distanceTo">DistanceTo to be created.</param>
        /// <param name="caseId">CaseId connected to the DistanceTo.</param>
        /// <returns>Returns the Id of the DistanceTo created.</returns>
        /// <author>René Sørensen</author>
        int CreateDistanceTo(DistanceTo distanceTo, int caseId);
    }
}
