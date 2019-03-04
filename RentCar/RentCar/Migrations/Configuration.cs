namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RentCar.Models;
    using RentCar.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<RentCar.DAL.CarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RentCar.DAL.CarContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Cars.AddOrUpdate(
                p=>p.March,
                new Cars
                {
                    Brend="BMW",
                    Model= "535",
                    March= 130000,
                    Capacity= 3.0,
                    Year= 2010,
                    Horseshoe= 306,
                    Fuel= "Benzin",
                    Image="car1.jpg"
                });
            context.Cars.AddOrUpdate(
              p => p.March,
              new Cars
              {
                  Brend = "Land Rover",
                  Model = "Range Rover",
                  March = 130000,
                  Capacity = 3.0,
                  Year = 2016,
                  Horseshoe = 258,
                  Fuel = "Dizel",
                  Image = "car2.jpg"
              });
        }
    }
}
