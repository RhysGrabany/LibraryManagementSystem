using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50), MinLength(5)]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(80), MinLength(10)]
        public string Author { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(17)]
        public string ISBN { get; set; }
    }
}
