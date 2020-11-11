using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    public class LibraryStock
    {
        [Required(ErrorMessage = "{0} is required")]
        public Library LibraryID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Book BookID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(2)]
        public int Stock { get; set; }
    }
}
