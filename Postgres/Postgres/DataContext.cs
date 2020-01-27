using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Postgres
{
    // kereli componentala;
    //Npsql.EntityFrameworkCore.PostgresSQL
    //Npsql.EntityFrameworkCore.PostgresSQL.Desig
    //Micrasoft.EntityFrameworkCore.SqlServer
    //Microsoft.EntityFrameworkCore.Tools
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=192.168.45.94;Port=5432;Database=b2bBase;Username=dev;Password=uzcard");
        }

    }
}
