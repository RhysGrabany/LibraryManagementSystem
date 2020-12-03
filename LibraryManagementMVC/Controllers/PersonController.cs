using LibraryManagementLibrary.DataAccess;
using LibraryManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Controllers
{
    public class PersonController : Controller
    {

        private readonly ILogger<PersonController> _logger;
        private readonly IDataConnection _sql;

        public IActionResult Index()
        {
            return View();
        }

        public PersonController(ILogger<PersonController> logger, IDataConnection sql)
        {
            _logger = logger;
            _sql = sql;
        }

        public ActionResult CustomerSignUp()
        {
            return View(new CustomerSignUpModel());
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


        public ActionResult SearchPeople()
        {
            return View(new SearchPeopleModel());
        }

        [HttpPost]
        public ActionResult SearchPeople(SearchPeopleModel vm, string SelectedPerson)
        {

            var SearchTerm = vm.SearchTerm;

            if (SelectedPerson == null)
            {
                vm.People = _sql.FindPeopleWithSearchTerm(SearchTerm);
                return View("SearchPeople", vm);
            }
            else
            {
                PersonModel SearchedPerson = new PersonModel();
                return View("PersonViewInfo", SearchedPerson);
            }
        }


        public async Task<IActionResult> PersonViewInfo(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var person = await _sql.GetPersonByIDAsync(id);

            return View("PersonViewInfo", person);
        }








    }
}
