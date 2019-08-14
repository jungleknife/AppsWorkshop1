using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProductCategory.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
