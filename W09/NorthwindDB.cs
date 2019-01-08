using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace W09
{
    class NorthwindDB : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        => builder.UseSqlServer(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

    }
}
