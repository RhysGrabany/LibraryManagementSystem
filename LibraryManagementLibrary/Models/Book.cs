using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    /// <summary>
    /// This is the Book ModelTable
    /// Used to hold information on books
    /// 
    /// +++++++++++++++++++++ 
    /// |   Book Table      |
    /// |-------------------|
    /// | PK | BookID       |
    /// |    | Title        |
    /// |    | Author       |
    /// |    | ISBN         |
    /// +++++++++++++++++++++
    /// </summary>
    public class Book
    {
        /// <summary>
        /// PK of the Book Table
        /// </summary>
        [Key]
        [Required]
        public int BookID { get; set; }

        /// <summary>
        /// Title of the book
        /// MaxLength(50), MinLength(5) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MinLength(5), MaxLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// Author of the book
        /// First and Last name saved together
        /// MaxLength(80), MinLength(10) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MinLength(10), MaxLength(80)]
        public string Author { get; set; }

        /// <summary>
        /// The ISBN of the book
        /// MinLength(10), MaxLength(13) Required -- MUST BE BETWEEN 10 AND 13 CHARACTERS LONG
        /// Follows no real format, but validation is based on a formula
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MinLength(10), MaxLength(13)]
        public string ISBN { get; set; }
    }
}
