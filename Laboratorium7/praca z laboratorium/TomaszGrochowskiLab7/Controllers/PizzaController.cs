using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomaszGrochowskiLab7.Models;
using TomaszGrochowskiLab7.Services;

namespace TomaszGrochowskiLab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        /// <summary>
        /// Zwraca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = _pizzaService.Get();
            return Ok(pizzas);
        }

        /// <summary>
        /// Dodaje nową pizzę
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]Pizza pizza)
        {
            int id = _pizzaService.Post(pizza);
            return Ok(id);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody]Pizza pizza, [FromRoute]int id)
        {
            if(id != pizza.Id)
            {
                return Conflict("Podane Id są różne");
            }
            else
            {
                var isUpdateSuccessful = _pizzaService.Put(pizza, id);

                if(isUpdateSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _pizzaService.Delete(id);
            
            if(result)
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
