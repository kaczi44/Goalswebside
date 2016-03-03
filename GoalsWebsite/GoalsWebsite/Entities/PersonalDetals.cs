using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GoalsWebsite.Entities
{
    public class PersonalDetals
    {
       public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adres { get; set; }
    }
}