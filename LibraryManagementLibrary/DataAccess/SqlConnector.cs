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

        public void AddNewPersonInformation(Person person, Address address, EmailAddress emailAddress)
        {

            person.EmailAddress = emailAddress;
            person.Addresses.Add(address);

            using (_db)
            {
                _db.People.Add(person);
                _db.SaveChanges();
            }
        }

        public Person GetPerson(Person person)
        {
            return _db.People
                .Where(x => x.FirstName == person.FirstName)
                .Where(x => x.LastName == person.LastName)
                .First();
        }

        public bool IsPersonSaved(Person person)
        {

            var isPersonCheck = _db.People
                .Where(x => x.FirstName == person.FirstName)
                .Where(x => x.LastName == person.LastName)
                .First();


            return (isPersonCheck != null) ? true : false;
        }

        public bool IsAddressSaved(Address address)
        {
            var isAddressCheck = _db.Addresses
                .Where(x => x.Postcode == address.Postcode)
                .Where(x => x.Number == address.Number)
                .First();

            return (isAddressCheck != null) ? true : false;

        }

    }
}
