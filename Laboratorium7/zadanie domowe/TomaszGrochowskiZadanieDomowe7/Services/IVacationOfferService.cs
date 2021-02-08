using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe7.Models;

namespace TomaszGrochowskiZadanieDomowe7.Services
{
    /// <summary>
    /// Interface with declarations of REST methods for VacationOffer
    /// </summary>
    public interface IVacationOfferService
    {
        /// <summary>
        /// Returning list of offers
        /// </summary>
        /// <returns></returns>
        List<VacationOffer> Get();

        /// <summary>
        /// Adding an offer
        /// </summary>
        /// <param name="vacationOffer"></param>
        /// <returns></returns>
        int Post(VacationOffer vacationOffer);

        /// <summary>
        /// Updating an offer
        /// </summary>
        /// <param name="vacationOffer"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Put(VacationOffer vacationOffer, int id);

        /// <summary>
        /// Deleting an offer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
