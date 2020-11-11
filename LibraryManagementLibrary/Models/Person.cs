using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    /// <summary>
    /// This is the Person ModelTable
    /// Used to hold the information on people
    /// Contains a One-To-One Relationship with Email Class (EmailAddress)
    /// ... a Many-To-Many Relationship with Address Class (Addresses)
    /// ... a One-To-Many Relationship with CheckedBooks Class (CheckedBooks)
    /// 
    /// +++++++++++++++++++++ 
    /// |   Person Table    |
    /// |-------------------|
    /// | PK | PersonID     |
    /// |    | FirstName    |
    /// |    | LastName     |
    /// |    | EmailAddress |
    /// |    | Addresses    |
    /// |    | CheckedBooks |
    /// +++++++++++++++++++++
    /// </summary>
    public class Person
    {
        /// <summary>
        /// PK of the Person table
        /// </summary>
        [Key]
        [Required]
        public int PersonID { get; set; }

        /// <summary>
        /// FirstName of the Person
        /// MaxLength(50), MinLength(3)
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50), MinLength(3)]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName of the Person
        /// MaxLength(50), MinLength(3)
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50), MinLength(3)]
        public string LastName { get; set; }

        /// <summary>
        /// EmailAddress of the Person
        /// One-To-One Relationship with EmailAddress table
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        public EmailAddresses EmailAddress { get; set; }

        /// <summary>
        /// Address of the Person
        /// Many-To-Many Relationship with Addresses table
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        public List<Addresses> Addresses { get; set; } = new List<Addresses>();

        /// <summary>
        /// CheckedBooks of the Person
        /// One-To-Many Relationship with CheckedBooks table
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        public List<CheckedBooks> CheckedBooks { get; set; } = new List<CheckedBooks>();
    }
}
