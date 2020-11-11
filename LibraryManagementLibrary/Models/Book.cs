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
        [MaxLength(50), MinLength(5)]
        public string Title { get; set; }

        /// <summary>
        /// Author of the book
        /// First and Last name saved together
        /// MaxLength(80), MinLength(10) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(80), MinLength(10)]
        public string Author { get; set; }

        /// <summary>
        /// The ISBN of the book
        /// MaxLength(13), MinLength(17) Required -- MUST BE BETWEEN 13 AND 17 CHARACTERS LONG
        /// Follows no real format, but validation is based on a formula
        /// ISBN-10 will have 3 dashes, and ISBN-13 will have 4 dashes
        /// ISBN-10 will have 978 prepended in order for it to work
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(13), MinLength(17)]
        public string ISBN { get; set; }
    }
}
