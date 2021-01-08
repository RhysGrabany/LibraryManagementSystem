using LibraryManagementLibrary.DataAccess;
using LibraryManagementLibrary.Models;
using LibraryManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<LibraryController> _logger;
        private readonly IDataConnection _sql;

        public LibraryController(ILogger<LibraryController> logger, IDataConnection sql)
        {
            _logger = logger;
            _sql = sql;
        }

        public ActionResult AddNewBook()
        {
            return View(new BookInformationModel());
        }

        [HttpPost]
        public IActionResult AddNewBook(BookInformationModel vm)
        {


            var author = vm.Book.Author;
            var title = vm.Book.Title;

            if(!_sql.IsBookSaved(title, author))
            {
                AddNewBookInfo(vm);
            }


            return View("AddNewBook", new Book());
        }


        public static void AddNewBookInfo(BookInformationModel vm)
        {

        }

    }
}
