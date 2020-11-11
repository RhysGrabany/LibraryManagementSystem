using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class LibraryStock
    {
        public Library LibraryID { get; set; }
        public Book BookID { get; set; }
        public int Stock { get; set; }
    }
}
