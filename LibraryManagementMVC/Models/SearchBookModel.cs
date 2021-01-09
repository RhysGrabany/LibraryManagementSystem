using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Models
{
    public class SearchBookModel
    {

        public string SearchTerm { get; set; }
        public List<BookResultModel> BookResults { get; set; } = new List<BookResultModel>();

        public Book Book { get; set; }
        public LibraryStock LibraryStock { get; set; }

    }
}
