namespace BookShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookShop.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookShop.DAL.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookShop.DAL.BookContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Books.AddOrUpdate(
                p=>p.Name,
                new Book
                {
                    Name="Cinayet ve ceza",
                    Author="Dostayevskiy",
                    Description="Bomba kitabdir",
                    Price=25,
                    Image="img1.jpeg"
                }
                
                );
            context.Books.AddOrUpdate(
                p=>p.Name,
                new Book {
                    Name="Celperengi ucuran",
                    Author="Xalid Huseyn",
                    Description="Pis kitabdir",
                    Price=17,
                    Image = "img2.jpeg"
                }
                );
            context.SaveChanges();
        }
    }
}
