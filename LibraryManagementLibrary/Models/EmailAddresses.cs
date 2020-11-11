using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// |    | EmailAddress     |
    /// +++++++++++++++++++++++++
    /// </summary>
    public class EmailAddresses
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
        [Required(ErrorMessage = "{0} is required")]
        public Person PersonID { get; set; }

        /// <summary>
        /// The email address of the person
        /// MaxLength(100) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(100)]
        public string EmailAddress { get; set; }
    }
}
