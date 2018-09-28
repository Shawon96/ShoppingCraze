using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Text;

namespace ShoppingCraze.DAL.Contexts
{
    public class CRSContext : DbContext
    {
        public CRSContext() : base("CRS")
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
