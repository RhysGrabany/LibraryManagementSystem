using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    /// <summary>
    /// This is the CheckedBooks ModelTable
    /// Used to hold the checked out books people will have
    /// Contains a One-To-One Relationship with Person Table (PersonID)
    /// ... a One-To-One Relationship with Book Table (BookID)
    /// 
    /// ++++++++++++++++++++++++
    /// |   CheckedBooks Table |
    /// |----------------------|
    /// | PK | CheckedBooksID  |
    /// | FK | PersonID        |
    /// | FK | BookID          |
    /// |    | ReturnDate      |
    /// ++++++++++++++++++++++++
    /// </summary>
    public class CheckedBooks
    {
        /// <summary>
        /// PK of the CheckedBooks Table
        /// </summary>
        [Key]
        [Required]
        public int CheckedBooksID { get; set; }

        /// <summary>
        /// FK from the Person Table
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        public Person PersonID { get; set; }

        /// <summary>
        /// FK from the Book Table
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        public Book BookID { get; set; }

        /// <summary>
        /// The return date for the book
        /// Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        public DateTime ReturnDate { get; set; }
    }
}
