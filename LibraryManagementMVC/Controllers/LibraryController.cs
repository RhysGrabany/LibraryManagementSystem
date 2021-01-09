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
        public async Task<IActionResult> AddNewBook(BookInformationModel vm)
        {
            // Checks if the book entry is present in the db, if false add book
            if(!_sql.IsBookSaved(vm.Book))
            {
                var LibraryStock = new LibraryStock();

                LibraryStock.Library = await _sql.GetLibraryModel(vm.LibraryID);
                LibraryStock.Stock = vm.Stock;

                _sql.AddNewBook(vm.Book, LibraryStock);
            }


            return View("AddNewBook", new BookInformationModel());
        }


        public ActionResult SearchBooks()
        {
            return View(new SearchBookModel());
        }

        [HttpPost]
        public async Task<ActionResult> SearchBooks(SearchBookModel vm)
        {
            // save the search term like this cause it's more readable
            var searchTerm = vm.SearchTerm;

            // Get all books that match the search term
            var books = await _sql.GetBooksBySearchTerm(searchTerm);

            // Put the books and stock level into a model, then add it to the list
            var bookResults = new List<BookResultModel>();
            foreach (var book in books)
            {
                // This looks neater to me compared to doing the same thing but with four lines extra
                bookResults.Add(
                    new BookResultModel() 
                    { 
                        Book = book,
                        Stock = _sql.GetBookStockById(book.BookID) 
                    });
            }

            return View(vm);
        }

    }
}
