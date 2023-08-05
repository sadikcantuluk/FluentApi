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
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.Date)
                .HasDefaultValueSql("GETDATE()");

            builder.HasData(
                new Book() { BookId = 1, Name = "Devlet", CategoryId = 3 },
                new Book() { BookId = 2, Name = "Cin Ali", CategoryId = 1 },
                new Book() { BookId = 3, Name = "Meryem", CategoryId = 1 },
                new Book() { BookId = 4, Name = "Şeker POtakalı", CategoryId = 2 }
                );

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
