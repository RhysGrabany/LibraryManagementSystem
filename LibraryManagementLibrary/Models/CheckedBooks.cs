using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class CheckedBooks
    {
        [Key]
        [Required]
        public int CheckedBooksID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Person PersonID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Book BookID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public DateTime ReturnDate { get; set; }
    }
}
