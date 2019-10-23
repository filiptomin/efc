using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDb.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Zavod> Zavods { get; set; }
        public DbSet<Zavodnik> Zavodniks { get; set; }
        public DbSet<ZavodnikZavod> ZavodnikZavods { get; set; }
        public ApplicationDbContext() : base()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Zavod>().HasData(new Zavod { ID = 1, Name = "A06", Place = "supr trať", Date = 12 / 4 / 2020 });
            modelBuilder.Entity<Zavod>().HasData(new Zavod { ID = 2, Name = "Číňan na kole", Place = "Singapur", Date = 14 / 5 / 2020 });
            modelBuilder.Entity<Zavod>().HasData(new Zavod { ID = 3, Name = "Vektor", Place = "Spšse", Date = 18 / 6 / 2020 });
            modelBuilder.Entity<Zavodnik>().HasData(new Zavodnik { ID = 1, FirstName = "" });
        }
    }
}
