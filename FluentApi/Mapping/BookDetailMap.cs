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
    public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(x => x.BookDetailId);

            builder.Property(x => x.ISSN)
                .IsRequired()
                .HasDefaultValue("0000-0000-0000");

            builder.Property(x => x.Year)
                .HasDefaultValue(DateTime.Now.Year);

            builder.HasOne(x => x.Book)
                .WithOne(x => x.BookDetail)
                .HasForeignKey<BookDetail>(x => x.BookDetailId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
