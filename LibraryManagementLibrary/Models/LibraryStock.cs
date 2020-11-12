using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    /// <summary>
    /// This is the LibraryStock ModelTable
    /// Used to hold the LibraryStock for a library
    /// Contains a One-To-One Relationship with Library Class (LibraryID)
    /// ... a One-To-One Relationship with Book Class (BookID)
    /// 
    /// +++++++++++++++++++++++++++
    /// |   LibraryStock Table    |
    /// |-------------------------|
    /// | PK | LibraryStockID     |
    /// | FK | LibraryID          |
    /// | FK | BookID             |
    /// |    | Stock              |
    /// +++++++++++++++++++++++++++
    /// </summary>
    public class LibraryStock
    {
        /// <summary>
        /// PK of the LibraryStock table
        /// </summary>
        [Key]
        [Required]
        public int LibraryStockID { get; set; }

        /// <summary>
        /// FK from the Library table
        /// </summary>
        [ForeignKey("LibraryID")]
        [Required(ErrorMessage = "{0} is required")]
        public Library Library { get; set; }

        /// <summary>
        /// FK from the Book table
        /// </summary>
        [ForeignKey("BookID")]
        [Required(ErrorMessage = "{0} is required")]
        public Book Book { get; set; }

        /// <summary>
        /// The stock of the book being stored
        /// MaxLength(2), MinLength(1)
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(2), MinLength(1)]
        public int Stock { get; set; }
    }
}
