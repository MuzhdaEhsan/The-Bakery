using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWebsite.Models
{
    public class Products
    {
        //getters / setters
        public int productsID { get; set; }

        public string prdName { get; set; }

        public int prdPrice { get; set; }

        public string prdDescription { get; set; }
    }
}
