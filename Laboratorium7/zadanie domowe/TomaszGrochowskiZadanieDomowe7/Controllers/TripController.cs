using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe7.Models;
using TomaszGrochowskiZadanieDomowe7.Services;

namespace TomaszGrochowskiZadanieDomowe7.Controllers
{
    /// <summary>
    /// Controller for Trips
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        /// <summary>
        /// Variable with service interface saved in it
        /// </summary>
        private ITripService _tripService;

        public TripController(ITripService tripService)
        {
            _tripService = tripService;
        }

        /// <summary>
        /// REST Get method returning the list of trips
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var offers = _tripService.Get();
            return Ok(offers);
        }

        /// <summary>
        /// REST Post method adding new trip
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Trip trip)
        {
            //Returning id of added trip
            int id = _tripService.Post(trip);
            return Ok(id);
        }

        /// <summary>
        /// REST Put method updating a chosen trip
        /// </summary>
        /// <param name="trip"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Trip trip, [FromRoute] int id)
        {
            //Checking if id given in body matches the id from the route
            if (id != trip.Id)
            {
                return Conflict("Given indexes are not equal");
            }
            else
            {
                //Checking if the update was performed successfully
                var isUpdateSuccessful = _tripService.Put(trip, id);

                //Returning adequate status
                if (isUpdateSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
        }

        /// <summary>
        /// REST Delete method deleting chosen trip
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            //Checking if deleting was performed successfully
            var result = _tripService.Delete(id);

            //Returning adequate status
            if (result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
