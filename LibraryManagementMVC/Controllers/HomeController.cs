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
            Person person = vm.Person;
            var address = vm.Address;

            bool isPersonSaved = _sql.IsPersonSaved(person);
            bool isAddressSaved = _sql.IsAddressSaved(address);


            if ()
            {
                return View(vm);
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
