using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookShop.Models 
{
    public class Book 
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        public double Price { get; set; }        
        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }
    }
}