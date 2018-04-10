using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetWorkshop5.Models
{
    public class SportsDB : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}