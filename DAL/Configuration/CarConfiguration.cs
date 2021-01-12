using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.CarId);

            builder.Property(c => c.CarId)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.LicenseNumber)
                //.HasMaxLength(8)
                .IsRequired();

            builder
                .HasOne(c => c.Owner)
                .WithMany(o => o.CarOwners)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasOne(ca => ca.Driver)
                .WithMany(cu => cu.CarDrivers)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientSetNull); ;

            //builder.HasData(
            //    new { CarId = 1, LicenseNumber = "1-ABC-23", Brand = "Audi", Model = "A4", OwnerId = 1, DriverId = 1 },
            //    new { CarId = 2, LicenseNumber = "9-ZYX-87", Brand = "BMW", Model = "M6", OwnerId = 2, DriverId = 2 },
            //    new { CarId = 3, LicenseNumber = "6-XXX-66", Brand = "Fiat", Model = "Punto", OwnerId = 3, DriverId = 3 },
            //    new { CarId = 4, LicenseNumber = "AB-CD-12", Brand = "Renault", Model = "Clio", OwnerId = 7, DriverId = 4 },
            //    new { CarId = 5, LicenseNumber = "98-ZY-XW", Brand = "Suzuki", Model = "Swift", OwnerId = 8, DriverId = 5 },
            //    new { CarId = 6, LicenseNumber = "XD-XD-88", Brand = "Toyota", Model = "Auris", OwnerId = 9, DriverId = 6 }
            //    );
        }
    }
}
