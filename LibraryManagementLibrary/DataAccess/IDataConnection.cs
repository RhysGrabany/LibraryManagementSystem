using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementLibrary.DataAccess
{
    public interface IDataConnection
    {

        void AddNewPersonInformation(Person person, Address address, EmailAddress emailAddress);

        Person GetPerson(Person person);

        bool IsPersonSaved(Person person);

        bool IsAddressSaved(Address address);

    }
}
