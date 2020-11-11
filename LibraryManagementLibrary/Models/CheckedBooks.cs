using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class CheckedBooks
    {
        public Person PersonID { get; set; }
        public Book BookID { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
