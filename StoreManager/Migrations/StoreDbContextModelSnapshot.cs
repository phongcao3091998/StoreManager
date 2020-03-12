﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreManager.Models;

namespace StoreManager.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoreManager.Models.Bills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("totalPrice");

                    b.HasKey("ID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("StoreManager.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BillsID");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("BillsID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StoreManager.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("eMail")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StoreManager.Models.Products", b =>
                {
                    b.HasOne("StoreManager.Models.Bills")
                        .WithMany("Products")
                        .HasForeignKey("BillsID");
                });
#pragma warning restore 612, 618
        }
    }
}