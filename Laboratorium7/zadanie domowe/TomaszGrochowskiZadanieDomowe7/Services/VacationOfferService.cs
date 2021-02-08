using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe7.Models;

namespace TomaszGrochowskiZadanieDomowe7.Services
{
    /// <summary>
    /// Service for VacationOffers with implementations of interface methods
    /// </summary>
    public class VacationOfferService : IVacationOfferService
    {
        /// <summary>
        /// List of offers
        /// </summary>
        private static List<VacationOffer> offers = new List<VacationOffer>()
        {
            new VacationOffer()
            {
                Id = 0,
                Country = "Egypt",
                HotelName = "Oasis",
                HotelRating = 4,
                Days = 12,
                Cost = 3400
            },
            new VacationOffer()
            {
                Id = 1,
                Country = "Italy",
                HotelName = "Roma",
                HotelRating = 3,
                Days = 7,
                Cost = 2100
            }
        };

        /// <summary>
        /// Implementation of Delete method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            //Searching for an offer with given id
            var offerToDelete = offers.Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (offerToDelete == null)
                return false;

            //Removing found offer
            offers.Remove(offerToDelete);
            return true;
        }

        /// <summary>
        /// Implementation of Get method
        /// </summary>
        /// <returns></returns>
        public List<VacationOffer> Get()
        {
            return offers;
        }

        /// <summary>
        /// Implementation of Post method
        /// </summary>
        /// <param name="vacationOffer"></param>
        /// <returns></returns>
        public int Post(VacationOffer vacationOffer)
        {
            //Assigning next id
            int id;
            if (offers.Count() == 0)
                id = 0;
            else
                id = offers.Max(x => x.Id) + 1;

            vacationOffer.Id = id;

            //Adding an offer
            offers.Add(vacationOffer);

            return id;
        }

        /// <summary>
        /// Implementation of Put method
        /// </summary>
        /// <param name="vacationOffer"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(VacationOffer vacationOffer, int id)
        {
            //Searching for offer with given id
            var offerToUpdate = offers.Where(x => x.Id.Equals(id)).SingleOrDefault();

            if (offerToUpdate == null)
                return false;

            //Updating data
            offerToUpdate.Country = vacationOffer.Country;
            offerToUpdate.HotelName = vacationOffer.HotelName;
            offerToUpdate.HotelRating = vacationOffer.HotelRating;
            offerToUpdate.Days = vacationOffer.Days;
            offerToUpdate.Cost = vacationOffer.Cost;

            return true;
        }
    }
}
