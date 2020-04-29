using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraningApp.Models
{
    public class Product
    {
       
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Product(int pId, string name, string descript, decimal price, string cat)
        {
            ProductId = pId;
            Name = name;
            Description = descript;
            Price = price;
            Category = cat;

        }
    }
}