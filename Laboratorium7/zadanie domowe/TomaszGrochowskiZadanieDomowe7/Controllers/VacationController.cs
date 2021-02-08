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
    /// Controller for VacationOffers
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VacationController : ControllerBase
    {
        /// <summary>
        /// Variable with service interface saved in it
        /// </summary>
        private IVacationOfferService _vacationOfferService;

        public VacationController(IVacationOfferService vacationOfferService)
        {
            _vacationOfferService = vacationOfferService;
        }

        /// <summary>
        /// REST Get method returning the list of vacation offers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var offers = _vacationOfferService.Get();
            return Ok(offers);
        }

        /// <summary>
        /// REST Post method adding new vacation offer
        /// </summary>
        /// <param name="vacationOffer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]VacationOffer vacationOffer)
        {
            //Returning id of added vacation offer
            int id = _vacationOfferService.Post(vacationOffer);
            return Ok(id);
        }

        /// <summary>
        /// REST Put method updating a chosen vacation offer
        /// </summary>
        /// <param name="vacationOffer"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] VacationOffer vacationOffer, [FromRoute] int id)
        {
            //Checking if id given in body matches the id from the route
            if (id != vacationOffer.Id)
            {
                return Conflict("Given indexes are not equal");
            }
            else
            {
                //Checking if the update was performed successfully
                var isUpdateSuccessful = _vacationOfferService.Put(vacationOffer, id);

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
        /// REST Delete method deleting chosen vacation offer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            //Checking if deleting was performed successfully
            var result = _vacationOfferService.Delete(id);

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
