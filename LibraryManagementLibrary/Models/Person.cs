using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmailAddresses EmailAddress { get; set; } 
        public List<Addresses> Addresses { get; set; } = new List<Addresses>();
        public List<CheckedBooks> CheckedBooks { get; set; } = new List<CheckedBooks>();
    }
}
