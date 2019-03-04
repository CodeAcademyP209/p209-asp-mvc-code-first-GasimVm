using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentCar.Models
{
    public class Cars
    {
        public int Id { get; set; }

        [StringLength(100)]
        [MinLength(3)]
        public string Brend { get; set; }

        [StringLength(100)]
        [MinLength(3)]
        public string Model { get; set; }

        [StringLength(100)]
        [MinLength(3)]
        public string Fuel { get; set; }

        public int Year { get; set; }
        public int Horseshoe { get; set; }
        public int March { get; set; }
        public double Capacity { get; set; }

        [StringLength(300)]
      
        public string Image { get; set; }
        [NotMapped]
        public string Photo { get; set; }
    }
}