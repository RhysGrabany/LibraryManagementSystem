using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementLibrary.DataAccess
{
    public interface IDataConnection
    {
        #region Adding Information

        /// <summary>
        /// Adding a new person with address to the database
        /// </summary>
        /// <param name="person">Person that is to be added to the database</param>
        /// <param name="address">Address that is to be added to the database</param>
        void AddNewPersonInformation(Person person, Address address);

        /// <summary>
        /// Adding a new person to an existing address in the address
        /// </summary>
        /// <param name="person">The new person to be added</param>
        /// <param name="address">The address that is to be modified</param>
        void AddNewPersonToExistingAddress(Person person, Address address);

        /// <summary>
        /// Adds a new address to an existing person in the database
        /// </summary>
        /// <param name="person">The person that is being modified</param>
        /// <param name="address">The address that is being added</param>
        void AddNewAddressToExistingPerson(Person person, Address address);

        /// <summary>
        /// Adds an existing address to an existing person in the database
        /// </summary>
        /// <param name="person">The existing person being utilised</param>
        /// <param name="address">The existing address being utilised</param>
        void AddExistingPersonToExistingAddress(Person person, Address address);

        void AddNewBook(Book book);

        #endregion

        #region Getting Information

        Task<Person> GetAllPersonInfoByIDAsync(int? id); 

        #region Getting Specific Results

        #region Address Information
        /// <summary>
        /// Getting the first result in the Addresses table when
        /// using a search basaed on postcode and number
        /// </summary>
        /// <param name="address">The address that is being searched for</param>
        /// <returns>The first address result as an Address model</returns>
        Address GetAddress(Address address);

        #endregion

        #region Person Information

        /// <summary>
        /// Get the first result in the Persons table 
        /// when using a search based on first name and last name
        /// </summary>
        /// <param name="person">The Person that is being searched for</param>
        /// <returns>A Person model with the search result</returns>
        Person GetPerson(Person person);

        /// <summary>
        /// Finds a person using the nullable id provided
        /// </summary>
        /// <param name="ID">The ID of the person being searched</param>
        /// <returns>Returns a task of the person that was searched</returns>
        Task<Person> GetPersonByIDAsync(int? ID);


        /// <summary>
        /// Finding a list of person with a search term string; uses the string for comparisons in first name and last name
        /// </summary>
        /// <param name="searchTerm">The string being searched in people</param>
        /// <returns>Returns a Task that contains the list of people</returns>
        Task<List<Person>> FindPeopleWithSearchTermAsync(string searchTerm);

        #endregion

        #endregion

        #region Information Checks

        /// <summary>
        /// Checks if a specific person is in the database or not
        /// </summary>
        /// <param name="person">The person being searched</param>
        /// <returns>True if Person entry is in Person Table, False if not</returns>
        bool IsPersonSaved(Person person);

        /// <summary>
        /// Checks if a specific address is in the database or not
        /// </summary>
        /// <param name="address">The address being searched</param>
        /// <returns>True if address is in the Addresses Table, False if not</returns>
        bool IsAddressSaved(Address address);

        /// <summary>
        /// Checks if a specific person is in related to a specific address
        /// </summary>
        /// <param name="person">Person being searched</param>
        /// <param name="address">Address being searched</param>
        /// <returns>True if the address has a relationship with the Person, False if not</returns>
        bool IsPersonAddressSaved(Person person, Address address);

        bool IsBookSaved(Book book);

        #endregion

        #endregion
    }
}
