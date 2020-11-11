using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class Addresses
    {
        public Person PersonID { get; set; }
        public string Town { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
    }
}
