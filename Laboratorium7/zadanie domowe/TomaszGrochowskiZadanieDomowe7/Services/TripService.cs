using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe7.Models;

namespace TomaszGrochowskiZadanieDomowe7.Services
{
    /// <summary>
    /// Service for Trips with implementations of interface methods
    /// </summary>
    public class TripService : ITripService
    {
        /// <summary>
        /// List of trips
        /// </summary>
        private static List<Trip> trips = new List<Trip>()
        {
            new Trip()
            {
                Id = 0,
                Name = "Safari",
                Hotel = "Oasis",
                Time = new TimeSpan(3, 30, 0),
                Cost = 350
            },
            new Trip()
            {
                Id = 1,
                Name = "Sightseeing",
                Hotel = "Oasis",
                Time = new TimeSpan(2, 0, 0),
                Cost = 150
            },
            new Trip()
            {
                Id = 2,
                Name = "Rome's monuments",
                Hotel = "Roma",
                Time = new TimeSpan(3, 00, 0),
                Cost = 300
            }
        };

        /// <summary>
        /// Implementation of Delete method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            //Searching for trip with given id
            var tripToDelete = trips.Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (tripToDelete == null)
                return false;

            //Removing found trip
            trips.Remove(tripToDelete);
            return true;
        }

        /// <summary>
        /// Implementation of Get method
        /// </summary>
        /// <returns></returns>
        public List<Trip> Get()
        {
            return trips;
        }

        /// <summary>
        /// Implementation of Post method
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        public int Post(Trip trip)
        {
            //Assigning next id
            int id;
            if (trips.Count() == 0)
                id = 0;
            else
                id = trips.Max(x => x.Id) + 1;

            trip.Id = id;

            //Adding new trip
            trips.Add(trip);

            return id;
        }

        /// <summary>
        /// Implementation of Put method
        /// </summary>
        /// <param name="trip"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(Trip trip, int id)
        {
            //Searching for trip with given id
            var tripToUpdate = trips.Where(x => x.Id.Equals(id)).SingleOrDefault();

            if (tripToUpdate == null)
                return false;

            //Updating data
            tripToUpdate.Name = trip.Name;
            tripToUpdate.Hotel = trip.Hotel;
            tripToUpdate.Time = trip.Time;
            tripToUpdate.Cost = trip.Cost;

            return true;
        }
    }
}
