using LibraryManagementLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {

        private readonly LibraryContext _db;

        public SqlConnector(LibraryContext db)
        {
            _db = db;
        }

        #region Adding Information

        /// <summary>
        /// Adding a new person with address to the database
        /// </summary>
        /// <param name="person">Person that is to be added to the database</param>
        /// <param name="address">Address that is to be added to the database</param>
        public void AddNewPersonInformation(Person person, Address address)
        {

            person.Addresses.Add(address);

            using (_db)
            {
                _db.People.Add(person);
                _db.SaveChanges();
            }
        }

        /// <summary>
        /// Adding a new person to an existing address in the address
        /// </summary>
        /// <param name="person">The new person to be added</param>
        /// <param name="address">The address that is to be modified</param>
        public void AddNewPersonToExistingAddress(Person person, Address address)
        {
            using (_db)
            {
                // Finds the first result that matches the postcode and number to the address supplied
                // There should only be one address that matches this search
                var addressToBeModified = _db.Addresses
                    .Where(x => x.Postcode == address.Postcode)
                    .Where(x => x.Number == address.Number)
                    .First();

                // Add the person to the list of Persons in the address and save the changes
                addressToBeModified.Persons.Add(person);
                _db.SaveChanges();

            }
        }

        /// <summary>
        /// Adds a new address to an existing person in the database
        /// </summary>
        /// <param name="person">The person that is being modified</param>
        /// <param name="address">The address that is being added</param>
        public void AddNewAddressToExistingPerson(Person person, Address address)
        {

            using (_db)
            {
                // Finds the person using a search based on last name and first name
                // This might be a problem for common names, but idgaf rn
                var personToBeModified = _db.People
                    .Where(x => x.LastName == person.LastName)
                    .Where(x => x.FirstName == person.FirstName)
                    .First();

                // Add the new address to the person entry and then save the changes
                personToBeModified.Addresses.Add(address);
                _db.SaveChanges();

            }


        }

        /// <summary>
        /// Adds an existing address to an existing person in the database
        /// </summary>
        /// <param name="person">The existing person being utilised</param>
        /// <param name="address">The existing address being utilised</param>
        public void AddExistingPersonToExistingAddress(Person person, Address address)
        {
            using (_db)
            {
                // Find the person and address based on checks below
                var personToBeModified = GetPerson(person);
                var addressToBeModified = GetAddress(address);

                // Save the address to the modified persons and then save the changes
                personToBeModified.Addresses.Add(addressToBeModified);
                _db.SaveChanges();

            }
        }

        #endregion

        #region Getting Information

        /// <summary>
        /// Get the first result in the Persons table 
        /// when using a search based on first name and last name
        /// </summary>
        /// <param name="person">The Person that is being searched for</param>
        /// <returns>A Person model with the search result</returns>
        public Person GetPerson(Person person)
        {
            return _db.People
                .Where(x => x.FirstName == person.FirstName)
                .Where(x => x.LastName == person.LastName)
                .First();
        }

        public Person GetPersonByID(int? ID)
        {
            return _db.People.Where(x => x.PersonID == ID).First();
        }
        /// <summary>
        /// Getting the first result in the Addresses table when
        /// using a search basaed on postcode and number
        /// </summary>
        /// <param name="address">The address that is being searched for</param>
        /// <returns>The first address result as an Address model</returns>
        public Address GetAddress(Address address)
        {
            return _db.Addresses
                    .Where(x => x.Postcode == address.Postcode)
                    .Where(x => x.Number == address.Number)
                    .First();
        }

        public List<Person> FindPeopleWithSearchTerm(string searchTerm)
        {

            return _db.People
                .Where(x => x.FirstName == searchTerm 
                        || x.LastName == searchTerm)
                .ToList();
        }


        #region Person/Address Checks

        /// <summary>
        /// Checks if a specific person is in the database or not
        /// </summary>
        /// <param name="person">The person being searched</param>
        /// <returns>True if Person entry is in Person Table, False if not</returns>
        public bool IsPersonSaved(Person person)
        {
            return _db.People
                .Where(x => x.LastName == person.LastName)
                .Any(x => x.FirstName == person.FirstName);
        }

        /// <summary>
        /// Checks if a specific address is in the database or not
        /// </summary>
        /// <param name="address">The address being searched</param>
        /// <returns>True if address is in the Addresses Table, False if not</returns>
        public bool IsAddressSaved(Address address)
        {
            return _db.Addresses
                .Where(x => x.Postcode == address.Postcode)
                .Any(x => x.Number == address.Number);

        }

        /// <summary>
        /// Checks if a specific person is in related to a specific address
        /// </summary>
        /// <param name="person">Person being searched</param>
        /// <param name="address">Address being searched</param>
        /// <returns>True if the address has a relationship with the Person, False if not</returns>
        public bool IsPersonAddressSaved(Person person, Address address)
        {
            // Finds the Person entry based on first and last name checks,
            // includes the addresses for the first result,
            // in address to look for the address based on postcode and number,
            // turn the result into a list, and if the result is more than 0
            return _db.People
                 .Where(p => p.FirstName == person.FirstName)
                 .Where(p => p.LastName == person.LastName)
                 .Include(i => i.Addresses)
                 .First()
                 .Addresses
                 .Where(a => a.Postcode == address.Postcode)
                 .Where(a => a.Number == address.Number)
                 .ToList()
                 .Count() > 0;

        }
        #endregion

        #endregion

    }
}
