using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RentCar.Models;

namespace RentCar.DAL
{
    public class CarContext : DbContext
    {
        public CarContext() :base("CarDContext")
        {
        }
        public DbSet<Cars> Cars { get; set; }
    }
}