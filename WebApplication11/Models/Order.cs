using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<ProductOrder> ProductOrder { get; set; }

        [DataType(DataType.Date)]
        public DateTime Bdate { get; set; }
    }
}