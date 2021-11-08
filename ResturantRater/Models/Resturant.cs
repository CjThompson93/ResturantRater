using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResturantRater.Models
{
    public class Resturant
    {
        public int ResturantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    public class ResturantDbContext : DbContext
    {
        public DbSet<Resturant> Resturants { get; set; }
    }
}