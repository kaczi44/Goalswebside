using GoalsWebsite.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoalsWebsite.DbContexts
{
    public class WebsiteContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public WebsiteContext() : base("DefaultConnection")
        {

        }
    }
}