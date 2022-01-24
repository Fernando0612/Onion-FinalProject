using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {

       public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_Personid");
            builder.Property(x => x.ID).ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasColumnType("Int");
            builder.Property(x => x.Name).ValueGeneratedOnAdd()
               .HasColumnName("Name")
               .HasColumnType("varchar(100)");
            builder.Property(x => x.LastName).ValueGeneratedOnAdd()
               .HasColumnName("LastName")
               .HasColumnType("varchar(100)");
            builder.Property(x => x.SocialSecurity).ValueGeneratedOnAdd()
               .HasColumnName("SocialSecurity")
               .HasColumnType("varchar(10)");
            builder.Property(x => x.Gender).ValueGeneratedOnAdd()
               .HasColumnName("Gender")
               .HasColumnType("varchar(10)");   

        }


    }
}
