using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Models
{
    public class CustomerSignUpModel
    {
        public Person Person { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public Address Address { get; set; }
    }
}
