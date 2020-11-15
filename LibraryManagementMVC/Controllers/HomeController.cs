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
        private readonly LibraryContext _db;

        public HomeController(ILogger<HomeController> logger, LibraryContext db)
        {
            _logger = logger;
            _db = db;
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
            Person person = vm.Person;
            List<Address> address = new List<Address>();
            address.Add(vm.Address);

            person.EmailAddress = vm.EmailAddress;


            foreach (var ad in address)
            {
                person.Addresses.Add(ad);
            }

            using (var db = _db)
            {
                db.People.Add(person);
                db.SaveChanges();
            }


            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
