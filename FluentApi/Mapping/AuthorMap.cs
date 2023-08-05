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
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.AuthorId);

            builder.Property(x => x.CreatedTime)
                .HasDefaultValueSql("GETDATE()");

            builder.Ignore(x => x.FullName);

            builder.HasData(
                new Author() { AuthorId = 1, FirstName = "Sadık", LastName = "Tuluk" },
                new Author() { AuthorId = 2, FirstName = "Yusuf", LastName = "Adil" },
                new Author() { AuthorId = 3, FirstName = "Mustafa", LastName = "Dumlupınar" }
                );
        }
    }
}
