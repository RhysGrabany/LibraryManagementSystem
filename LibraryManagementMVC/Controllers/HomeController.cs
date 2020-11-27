using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LibraryManagementMVC.Models;
using LibraryManagementLibrary.Models;
using LibraryManagementLibrary.DataAccess;

namespace LibraryManagementMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataConnection _sql;

        public HomeController(ILogger<HomeController> logger, IDataConnection sql)
        {
            _logger = logger;
            _sql = sql;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Person()
        {
            return View();
        }

        public ActionResult CustomerSignUp()
        {
            CustomerSignUpModel vm = new CustomerSignUpModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult CustomerSignUp(CustomerSignUpModel vm)
        {

            // Moving the data to their own containers cause it looks nicer
            var person = vm.Person;
            var address = vm.Address;
            // Putting in the email address to the person straight away
            person.EmailAddress = vm.EmailAddress;

            // Checks to see if the person/address is saved or not
            bool isPersonSaved = _sql.IsPersonSaved(person);
            bool isAddressSaved = _sql.IsAddressSaved(address);


            if (isPersonSaved || isAddressSaved)
            {
                if (isPersonSaved)
                {
                    if (!isAddressSaved)
                        // The person is saved, but no the address, so this adds the new address to the person
                        _sql.AddNewAddressToExistingPerson(person, address);

                    if (isAddressSaved)
                    {
                        // Checks to see if the current address is in the current person
                        bool isPersonAddressSaved = _sql.IsPersonAddressSaved(person, address);

                        if (!isPersonAddressSaved)
                            _sql.AddExistingPersonToExistingAddress(person, address);
                        
                        return View(vm);
                    }
                }
                else
                {
                    if (isAddressSaved)
                        // The person is not saved but the address is, this adds the new person to the address
                        _sql.AddNewPersonToExistingAddress(person, address);
                }
            }
            else
            {
                _sql.AddNewPersonInformation(person, address);
            }


            return View(vm);
        }


        public IActionResult SearchPersons()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
