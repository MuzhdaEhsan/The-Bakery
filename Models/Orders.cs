using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWebsite.Models
{
    public class Orders
    {
        //getters / setters
        public int ordersID { get; set; }
       
        public int productID { get; set; }

        public string ordQuantity { get; set; }

        public string ordDate { get; set; }

        public string ordDescription { get; set; }
    }
}
