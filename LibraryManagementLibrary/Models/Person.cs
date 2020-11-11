using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EmailAddresses> EmailAddress { get; set; } = new List<EmailAddresses>();
        public List<Addresses> Addresses { get; set; } = new List<Addresses>();
        public List<CheckedBooks> CheckedBooks { get; set; } = new List<CheckedBooks>();
    }
}
