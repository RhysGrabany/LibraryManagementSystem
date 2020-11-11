using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class Addresses
    {
        [Required(ErrorMessage = "{0} is required")]
        public List<Person> PersonID { get; set; } = new List<Person>();

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50)]
        public string Town { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(3)]
        public int Number { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(80)]
        public string Address { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(7)]
        public string Postcode { get; set; }
    }
}
