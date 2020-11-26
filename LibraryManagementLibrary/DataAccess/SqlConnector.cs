using LibraryManagementLibrary.Models;
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

        public void AddNewPersonInformation(Person person, Address address)
        {

            person.Addresses.Add(address);

            using (_db)
            {
                _db.People.Add(person);
                _db.SaveChanges();
            }
        }

        public void AddNewPersonToAddress(Person person, Address address)
        {


            using (_db)
            {

                var addressToBeModified = _db.Addresses
                    .Where(x => x.Postcode == address.Postcode)
                    .Where(x => x.Number == address.Number)
                    .First();


                addressToBeModified.Persons.Add(person);

                _db.SaveChanges();

            }
        }

        public void AddNewAddressToPerson(Person person, Address address)
        {

            using (_db)
            {

                var personToBeModified = _db.People
                    .Where(x => x.LastName == person.LastName)
                    .Where(x => x.FirstName == person.FirstName)
                    .First();


                personToBeModified.Addresses.Add(address);

                _db.SaveChanges();

            }


        }
        public void AddExistingPersonToExistingAddress(Person person, Address address)
        {
            using (_db)
            {
                var personToBeModified = _db.People
                    .Where(x => x.LastName == person.LastName)
                    .Where(x => x.FirstName == person.FirstName)
                    .First();

                var addressToBeModified = _db.Addresses
                    .Where(x => x.Postcode == address.Postcode)
                    .Where(x => x.Number == address.Number)
                    .First();


                personToBeModified.Addresses.Add(addressToBeModified);

                _db.SaveChanges();

            }
        }





        #endregion

        #region Getting Information

        public Person GetPerson(Person person)
        {
            return _db.People
                .Where(x => x.FirstName == person.FirstName)
                .Where(x => x.LastName == person.LastName)
                .First();
        }

        public bool IsPersonSaved(Person person)
        {
            return _db.People
                .Where(x => x.LastName == person.LastName)
                .Any(x => x.FirstName == person.FirstName);
        }

        public bool IsAddressSaved(Address address)
        {
            return _db.Addresses
                .Where(x => x.Postcode == address.Postcode)
                .Any(x => x.Number == address.Number);

        }

        public bool IsPersonAddressSaved(Person person, Address address)
        {
           return _db.People
                .Where(x => x.FirstName == person.FirstName)
                .Where(x => x.LastName == person.LastName)
                .First().Addresses
                .ToList()
                .Contains(address);
        }


        #endregion

    }
}
