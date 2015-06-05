using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Database
{
    internal interface IPartnerDB
    {
        /// <summary>
        /// Returns all the Partners from the database.
        /// </summary>
        /// <returns>Returns a List of all the Partners from the database.</returns>
        /// <author>René Sørensen</author>
        List<Partner> ReadPartners();

        /// <summary>
        /// Updates the information from a Partner, in the database.
        /// </summary>
        /// <param name="partner">Partner to be updated.</param>
        /// <author>René Sørensen</author>
        void UpdatePartner(Partner partner);

        /// <summary>
        /// Creates a new Partner in the database.
        /// </summary>
        /// <param name="partner">Partner to be created.</param>
        /// <returns>Returns the Id of the Partner created.</returns>
        /// <author>René Sørensen</author>
        int CreatePartner(Partner partner);
    }
}
