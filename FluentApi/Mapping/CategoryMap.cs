using FluentAPI.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x=>x.CategoryId);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasData(
                new Category() { CategoryId = 1,Name="Sağlık"},
                new Category() { CategoryId = 2,Name="Bilim"},
                new Category() { CategoryId = 3,Name="Siyaset"}
                ) ;
        }
    }
}
