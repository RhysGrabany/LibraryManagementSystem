using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementLibrary.Models
{
    /// <summary>
    /// This is the Addresses ModelTable
    /// Used to hold the address for people
    /// Contains a Many-To-Many Relationship with Person Class (Persons)
    /// 
    /// ++++++++++++++++++++ 
    /// |  Addresses Table |
    /// |------------------|
    /// | PK | AddressID   |
    /// |    | Persons     |
    /// |    | Town        |
    /// |    | Number      |
    /// |    | AddressLine |
    /// |    | Postcode    |
    /// ++++++++++++++++++++
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Primary Key for Adresses Table
        /// </summary>
        [Key]
        [Required]
        public int AddressesID { get; set; }

        /// <summary>
        /// Many-To-Many Relationship with Person Table
        /// Many people can reside in Many Addresses
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        public List<Person> Persons { get; set; } = new List<Person>();

        /// <summary>
        /// Town name field
        /// MaxLength(50), MinLength(5) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50), MinLength(5)]
        public string Town { get; set; }

        /// <summary>
        /// Number of the house
        /// MaxLength(3), MinLength(1) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Number must be a natural number")]
        public int Number { get; set; }
        
        /// <summary>
        /// Address of the house
        /// MaxLength(80), MinLength(5) Required
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(80), MinLength(5)]
        public string AddressLine { get; set; }

        /// <summary>
        /// Postcode of the address
        /// MaxLength(7), MinLength(7) Required -- MUST BE 7 CHARACTERS (LLNNNLL formatting) 
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(7), MinLength(7)]
        public string Postcode { get; set; }
    }
}
