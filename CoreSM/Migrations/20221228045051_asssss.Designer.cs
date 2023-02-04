﻿// <auto-generated />
using System;
using CoreSM.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreSM.Migrations
{
    [DbContext(typeof(SalesDbContext))]
    [Migration("20221228045051_asssss")]
    partial class asssss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreSM.Models.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNIC");

                    b.Property<DateTime>("InvoiceDate");

                    b.Property<int>("SaleCategoryID");

                    b.Property<string>("SaleType");

                    b.Property<decimal>("TaxAmount");

                    b.Property<string>("TaxPayerType");

                    b.Property<decimal>("TaxRate");

                    b.Property<string>("TaxWithheld");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("CoreSM.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNIC");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<int>("SaleCategoryID");

                    b.Property<string>("SaleType");

                    b.Property<decimal>("TaxAmount");

                    b.Property<string>("TaxPayerType");

                    b.Property<decimal>("TaxRate");

                    b.Property<string>("TaxWithheld");

                    b.Property<int>("UserID");

                    b.Property<bool>("isCreated");

                    b.HasKey("ID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("CoreSM.Models.SalesCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("PayerType");

                    b.Property<decimal>("TaxRate");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("SalesCategory");
                });

            modelBuilder.Entity("CoreSM.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
