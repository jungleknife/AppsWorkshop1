using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProductCategory.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string OwnerID { get; set; }
        public int? CategoryID { get; set; }
        public int? StatusID { get; set; }
        public Category Category { get; set; }
        public Status Status { get; set; }
    }
}
