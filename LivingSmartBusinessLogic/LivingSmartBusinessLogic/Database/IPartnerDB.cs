using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IPartnerDB
    {
        /// <summary>
        /// Returns all the Partners from the database.
        /// </summary>
        /// <returns>Returns a List of all the Partners from the database.</returns>
        List<Partner> ReadPartners();

        /// <summary>
        /// Updates the information from a Partner, in the database.
        /// </summary>
        /// <param name="partner">Partner to be updated.</param>
        void UpdatePartner(Partner partner);

        /// <summary>
        /// Creates a new Partner in the database.
        /// </summary>
        /// <param name="partner">Partner to be created.</param>
        /// <returns>Returns the Id of the Partner created.</returns>
        int CreatePartner(Partner partner);
    }
}
