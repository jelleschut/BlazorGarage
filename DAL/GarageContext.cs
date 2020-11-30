using DAL.Configuration;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class GarageContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<CarModel> CarModels { get; set; }

        public GarageContext()
        {

        }

        public GarageContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json");
            var configuration = builder.Build();

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(configuration.GetConnectionString("GarageDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Brand>(new BrandConfiguration());
            modelBuilder.ApplyConfiguration<Car>(new CarConfiguration());
            modelBuilder.ApplyConfiguration<Owner>(new OwnerConfiguration());
            modelBuilder.ApplyConfiguration<Maintenance>(new MaintenanceConfiguration());
            modelBuilder.ApplyConfiguration<CarModel>(new CarModelConfiguration());
        }

    }
}
