using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PipsiProject.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {

        }

        public DbSet<CarModel> Cars { get; set; }
        public DbSet<ImageModel> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<CarModel>().ToTable("Cars");
            modelBuilder.Entity<ImageModel>().ToTable("Images");
        }

    }
}
