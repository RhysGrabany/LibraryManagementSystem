using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Models
{
    public class SearchPeopleModel
    {
        /// <summary>
        /// The search term being used to find the person in db
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// The list of people returned from the search
        /// </summary>
        public List<Person> People { get; set; } = new List<Person>();

        /// <summary>
        /// A person model being used mostly for headings
        /// </summary>
        public Person Person { get; set; }
    }
}
