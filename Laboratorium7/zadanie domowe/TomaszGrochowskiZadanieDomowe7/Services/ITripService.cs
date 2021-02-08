using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe7.Models;

namespace TomaszGrochowskiZadanieDomowe7.Services
{
    /// <summary>
    /// Interface with declarations of REST methods for Trip
    /// </summary>
    public interface ITripService
    {
        /// <summary>
        /// Returning list of trips
        /// </summary>
        /// <returns></returns>
        List<Trip> Get();
        
        /// <summary>
        /// Adding a trip
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        int Post(Trip trip);

        /// <summary>
        /// Updating a trip
        /// </summary>
        /// <param name="trip"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Put(Trip trip, int id);

        /// <summary>
        /// Deleting a trip
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
