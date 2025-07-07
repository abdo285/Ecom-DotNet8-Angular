using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Config
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property( x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Id).IsRequired();
            // Seed Data
            builder.HasData(
                new Category { Id = 1, Name = "Electronics", Description="test",
                    CreatedAt = new DateTime(2024, 01, 01)
                },
                new Category { Id = 2, Name = "Books", Description = "test",
                    CreatedAt = new DateTime(2024, 01, 01)
                },
                new Category { Id = 3, Name = "Clothing", Description = "test",
                    CreatedAt = new DateTime(2024, 01, 01)
                }
            );

        }
    }
}
