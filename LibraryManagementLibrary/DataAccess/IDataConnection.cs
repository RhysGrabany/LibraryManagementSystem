using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementLibrary.DataAccess
{
    public interface IDataConnection
    {

        void AddNewPersonInformation(Person person, Address address);

        void AddNewPersonToAddress(Person person, Address address);

        void AddNewAddressToPerson(Person person, Address address);

        void AddExistingPersonToExistingAddress(Person person, Address address);


        Person GetPerson(Person person);

        bool IsPersonSaved(Person person);

        bool IsAddressSaved(Address address);

        bool IsPersonAddressSaved(Person person, Address address);

    }
}
