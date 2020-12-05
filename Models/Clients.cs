using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWebsite.Models
{
    public class Clients
    {
        //getters / setters
        public int clientsID { get; set; }

        public int orderID { get; set; }

        public string clName { get; set; }

        public string clLastName { get; set; }

        public string clPhone { get; set; }

        public string clEmail { get; set; }
        public string clStreet { get; set; }

        public string clCity { get; set; }

        public string clPostalcode { get; set; }
    }
}
