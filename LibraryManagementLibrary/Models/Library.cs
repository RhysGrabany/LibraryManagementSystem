using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementLibrary.Models
{
    /// <summary>
    /// This is the Library ModelTable
    /// Used to hold the information on the library
    /// 
    /// +++++++++++++++++++++ 
    /// |   Library Table   |
    /// |-------------------|
    /// | PK | LibraryID    |
    /// |    | LibraryName  |
    /// +++++++++++++++++++++
    /// </summary>
    public class Library
    {
        /// <summary>
        /// PK of the Library Table
        /// </summary>
        [Key]
        [Required]
        public int LibraryID { get; set; }

        /// <summary>
        /// Name of the Library
        /// MaxLength(50) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50)]
        public string LibraryName { get; set; }
    }
}
