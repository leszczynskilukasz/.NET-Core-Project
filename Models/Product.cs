using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
