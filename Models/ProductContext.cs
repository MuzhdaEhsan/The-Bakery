using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BakeryWebsite.Models
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {



        }

        public DbSet<Products> Product { get; set; }


        public DbSet<Orders> Order { get; set; }

        public DbSet<Clients> Client { get; set; }
    }
}
