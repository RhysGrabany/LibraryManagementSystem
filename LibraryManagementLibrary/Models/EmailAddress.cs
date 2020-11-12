using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    /// <summary>
    /// This is the EmailAddress ModelTable
    /// Used to hold the information on email for people
    /// Contains a One-To-One Relationship with Person Table (PersonID)
    /// 
    /// +++++++++++++++++++++++++
    /// |   Email Address Table |
    /// |-----------------------|
    /// | PK | CheckedBooksID   |
    /// | FK | PersonID         |
    /// |    | Email            |
    /// +++++++++++++++++++++++++
    /// </summary>
    public class EmailAddress
    {
        /// <summary>
        /// PK of the EmailAddress table
        /// </summary>
        [Key]
        [Required]
        public int EmailAddressesID { get; set; }

        /// <summary>
        /// FK from the Person Table
        /// </summary>
        [ForeignKey("PersonID")]
        [Required(ErrorMessage = "{0} is required")]
        public Person Person { get; set; }

        /// <summary>
        /// The email address of the person
        /// MaxLength(100) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
