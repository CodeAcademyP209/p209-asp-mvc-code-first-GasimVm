using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookShop.Models;

namespace BookShop.DAL
{
    public class BookContext : DbContext
    {
        public BookContext() :base("BookContext")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}