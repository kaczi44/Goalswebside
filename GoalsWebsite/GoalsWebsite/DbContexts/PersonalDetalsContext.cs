using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GoalsWebsite.Entities;

namespace GoalsWebsite.DbContexts
{
    public class PersonalDetalsContext : DbContext
    {
        public  DbSet<PersonalDetals> Detals  { get; set; }

        public PersonalDetalsContext():base("DefaultConnection")
        {
            
        }
    }
}