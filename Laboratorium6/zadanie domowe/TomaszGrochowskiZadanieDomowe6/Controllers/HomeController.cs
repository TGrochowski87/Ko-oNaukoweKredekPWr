using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe6.Models;

namespace TomaszGrochowskiZadanieDomowe6.Controllers
{
    /// <summary>
    /// Program's controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// List of currencies
        /// </summary>
        static List<CurrencyViewModel> currencies = new List<CurrencyViewModel>
            {
                new CurrencyViewModel{Name = "Euro", Value = 4.54f },
                new CurrencyViewModel{Name = "American Dollar", Value = 3.74f },
                new CurrencyViewModel{Name = "Australian Dollar", Value = 2.91f },
                new CurrencyViewModel{Name = "British Pound", Value = 5.11f },
                new CurrencyViewModel{Name = "Norwegian Crown", Value = 0.44f },
            };

        public HomeController()
        {
        }

        /// <summary>
        /// Method to launch first view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Output for Index Get form
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(UserViewModel user)
        {
            string fullName = user.FirstName + " " + user.LastName;
            //Passing user data to next view
            ViewBag.User = fullName;
            return View("Menu");
        }

        /// <summary>
        /// Method to launch get form allowing user to choose currency  for calculation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CurrencyChooser()
        {
            //Creating list of names to be shown in view
            List<string> currencyNames = new List<string>();
            foreach(CurrencyViewModel c in currencies)
            {
                currencyNames.Add(c.Name);
            }

            return View(currencyNames);
        }

        /// <summary>
        /// Method to list saved currencies in view
        /// </summary>
        /// <returns></returns>
        public IActionResult CurrencyList()
        {
            return View(currencies);
        }

        /// <summary>
        /// Method for showing calculation result
        /// </summary>
        /// <param name="currencyName"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CalculationResult(string currencyName, float amount)
        {
            //Checking which currency has been chosen
            CurrencyViewModel currencyToCalculate = currencies.Where(c => c.Name.ToLower() == currencyName.ToLower()).FirstOrDefault();
            //Calculating result
            float result = amount * currencyToCalculate.Value;
            //Saving result in TempData
            TempData["Result"] = result;

            return View();
        }

        /// <summary>
        /// Method with form for adding new currency to the list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddCurrency()
        {
            return View();
        }

        /// <summary>
        /// Output for AddCurrency Get form
        /// </summary>
        /// <param name="newCurrency"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddCurrency(CurrencyViewModel newCurrency)
        {
            //Adding new currency and going back to menu
            currencies.Add(newCurrency);
            return View("Menu");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
