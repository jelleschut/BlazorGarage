using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    class MaintenanceConfiguration : IEntityTypeConfiguration<Maintenance>
    {
        public void Configure(EntityTypeBuilder<Maintenance> builder)
        {
            builder.HasKey(ms => ms.MaintenanceId);

            builder.Property(ms => ms.MaintenanceId)
                .ValueGeneratedOnAdd();

            builder.Property(ms => ms.Date)
                .IsRequired();

            builder.Property(ms => ms.Milage)
                .IsRequired();

            builder.Property(ms => ms.MaintenanceType)
                .IsRequired();

            builder.Property(ms => ms.MaintenanceType)
                .HasConversion(
                v => v.ToString(),
                v => (MaintenanceEnum)Enum.Parse(typeof(MaintenanceEnum), v));

            builder.HasOne(ms => ms.Car)
                .WithMany(c => c.Maintenances)
                .IsRequired();

            builder.HasData(
                new { MaintenanceId = 1, Date = DateTime.Now, Milage = 1234567890, Description = "Reparatie", MaintenanceType = MaintenanceEnum.REPAIR, CarId = 1 },
                new { MaintenanceId = 2, Date = DateTime.Now, Milage = 1234567890, Description = "Reparatie", MaintenanceType = MaintenanceEnum.REPAIR, CarId = 2 },
                new { MaintenanceId = 3, Date = DateTime.Now, Milage = 1234567890, Description = "Reparatie", MaintenanceType = MaintenanceEnum.REPAIR, CarId = 3 },
                new { MaintenanceId = 4, Date = DateTime.Now, Milage = 1234567890, Description = "APK", MaintenanceType = MaintenanceEnum.MOT, CarId = 4, Id = 4 },
                new { MaintenanceId = 5, Date = DateTime.Now, Milage = 1234567890, Description = "APK", MaintenanceType = MaintenanceEnum.MOT, CarId = 5, Id = 5 },
                new { MaintenanceId = 6, Date = DateTime.Now, Milage = 1234567890, Description = "APK", MaintenanceType = MaintenanceEnum.MOT, CarId = 6, Id = 6 }
                );
        }
    }
}
