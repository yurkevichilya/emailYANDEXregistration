using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
    
        public int Price { get; set; }

        public virtual List<ProductOrder> ProductOrder { get; set; }

        public Product()
        {

        }

        public Product(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;

        }
    }
}