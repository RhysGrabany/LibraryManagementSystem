using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class Person
    {

        [Key]
        [Required]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50), MinLength(3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50), MinLength(3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public EmailAddresses EmailAddress { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public List<Addresses> Addresses { get; set; } = new List<Addresses>();

        [Required(ErrorMessage = "{0} is required")]
        public List<CheckedBooks> CheckedBooks { get; set; } = new List<CheckedBooks>();
    }
}
