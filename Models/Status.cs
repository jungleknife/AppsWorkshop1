using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProductCategory.Models
{
    public class Status
    {
        public int StatusID { get; set; }
        public string Condition { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
