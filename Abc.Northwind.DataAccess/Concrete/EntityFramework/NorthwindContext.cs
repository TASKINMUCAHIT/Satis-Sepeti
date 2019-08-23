using Abc.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.DataAccess.Concrete.EntityFramework;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Trusted_Connection=false
            //Server=desktop-9jstoer\sqlexpress; Database = NORTHWIND;Integrated Security=True
            //Server=desktop-9jstoer\SQLEXPRESS; Database = NORTHWIND;Trusted_Connection=True;
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9JSTOER\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
        }

        public DbSet<Product> Products    { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
