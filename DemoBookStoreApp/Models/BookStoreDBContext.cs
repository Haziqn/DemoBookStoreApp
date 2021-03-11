using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoBookStoreApp.Models
{
    public class BookStoreDBContext : DbContext
    {
        public DbSet<BookStore> BookStore { get; set; }
        public BookStoreDBContext()
        {
            Database.SetInitializer<BookStoreDBContext>(new DropCreateDatabaseIfModelChanges<BookStoreDBContext>());
        }

    }
}