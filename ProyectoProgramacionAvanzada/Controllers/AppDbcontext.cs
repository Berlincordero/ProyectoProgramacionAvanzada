
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using ProyectoProgramacionAvanzada.Models;
using System.Collections.Generic;

namespace ProyectoProgramacionAvanzada.Controllers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


        public DbSet<Product_Image> ProductImages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
