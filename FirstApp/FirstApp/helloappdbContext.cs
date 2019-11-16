using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstApp
{
    public partial class helloappdbContext : DbContext
    {
        public helloappdbContext()
        {
        }

        public helloappdbContext(DbContextOptions<helloappdbContext> options)// inkapsulatsiya qilish bazani
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasKey(u => u.Ident);     //Для конфигурации ключа с Fluent API применяется метод HasKey():
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");
        }
    }
}
