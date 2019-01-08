using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace W08
{
    class NorthwindDB : DbContext
    {
        public NorthwindDB()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        }

    }
}
