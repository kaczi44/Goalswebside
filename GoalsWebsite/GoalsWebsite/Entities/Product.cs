using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoalsWebsite.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public double Price { get; set; }
    }
}