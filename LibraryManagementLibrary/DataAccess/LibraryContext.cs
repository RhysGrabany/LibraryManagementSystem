using LibraryManagementLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementLibrary.DataAccess
{
    public class LibraryContext : DbContext
    {
   
        public LibraryContext(DbContextOptions options) : base(options) { }

        // Library Info with Stock and Books
        #region Library Info
        public DbSet<Library> Library { get; set; }
        public DbSet<LibraryStock> LibraryStocks { get; set; }
        public DbSet<Book> Books { get; set; }
        #endregion

        //Person Info with Addresses, Email Addresses, and Checked Books
        #region People Info
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<CheckedBook> CheckedBooks { get; set; }
        #endregion
    }
}
