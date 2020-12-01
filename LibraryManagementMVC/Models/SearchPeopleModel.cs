using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Models
{
    public class SearchPeopleModel
    {

        public string SearchTerm { get; set; }
        public List<Person> People { get; set; } = new List<Person>();


    }
}
