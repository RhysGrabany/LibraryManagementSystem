using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementLibrary.Models
{
    public class Library
    {
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50)]
        public string LibraryName { get; set; }
    }
}
