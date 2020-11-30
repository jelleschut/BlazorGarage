using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.HasKey(m => m.CarModelId);

            builder.Property(m => m.CarModelId)
                .ValueGeneratedOnAdd();

            builder.Property(m => m.Name)
                .IsRequired();

            builder.
                HasOne(m => m.Brand)
                .WithMany(b => b.CarModels)
                .IsRequired();

            builder.
                HasData(
                new { CarModelId = 1, Name = "A4", BrandId = 1 },
                new { CarModelId = 2, Name = "M6", BrandId = 2 },
                new { CarModelId = 3, Name = "Punto", BrandId = 3 },
                new { CarModelId = 4, Name = "Clio", BrandId = 4 },
                new { CarModelId = 5, Name = "Superb", BrandId = 5 },
                new { CarModelId = 6, Name = "Golf", BrandId = 6 }
                );
        }
    }
}
