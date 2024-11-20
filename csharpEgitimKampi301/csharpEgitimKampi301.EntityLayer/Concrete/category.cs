using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpEgitimKampi301.EntityLayer.Concrete
{
    public class category
    {
        public int categoryId { get;set; }
        public string categoryName { get;set; } 

        public bool categoryStatus { get;set; }
        public List<Product> Products { get; set; }

    }
}
