﻿using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Config
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x=>x.Price).HasColumnType("decimal(18,2)");
            builder.HasData(
             new Product { Id = 1, Name = "test", Description = "test",CategoryId=1,Price=120,
                 CreatedAt = new DateTime(2024, 01, 01)
             }

         );

        }
    }
}
