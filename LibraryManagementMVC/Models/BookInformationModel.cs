﻿using LibraryManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Models
{
    public class BookInformationModel
    {

        public Book Book { get; set; }
        public int Stock { get; set; }

        public LibraryStock LibraryStock { get; set; }

        public int LibraryID { get; set; } = 1;
    }
}