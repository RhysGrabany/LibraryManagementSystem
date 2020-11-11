using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class EmailAddresses
    {

        [Key]
        [Required]
        public int EmailAddressesID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Person PersonID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(100)]
        public string EmailAddress { get; set; }
    }
}
