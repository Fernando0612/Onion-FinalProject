﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220120053343_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainLayer.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Gender");

                    b.Property<string>("LastName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("LastName");

                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("SocialSecurity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SocialSecurity");

                    b.HasKey("ID")
                        .HasName("pk_Personid");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
