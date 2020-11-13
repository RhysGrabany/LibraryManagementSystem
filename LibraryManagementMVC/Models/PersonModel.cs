using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Models
{
    public class PersonModel : Person
    {
        [Display(Name = "Confim Email")]
        [Compare("Email Address")]
        public string EmailAddressConfirm { get; set; }
    }
}
