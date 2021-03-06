﻿// <auto-generated />
using System;
using KerryExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KerryExample.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AptechMVCProject.Entity.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CardTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardTypeRefId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("TotalMoney")
                        .HasColumnType("float");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserRefId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("AptechMVCProject.Entity.CartDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CartRefId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Detailses");
                });

            modelBuilder.Entity("AptechMVCProject.Entity.CartType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CartTypes");
                });

            modelBuilder.Entity("AptechMVCProject.Entity.ProductListInCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductRefId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartDetailsId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductListInCarts");
                });

            modelBuilder.Entity("AptechMVCProject.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KerryExample.Entity.Catgory", b =>
                {
                    b.Property<string>("CatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CatId");

                    b.ToTable("Catgories");
                });

            modelBuilder.Entity("KerryExample.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CatgoryCatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CatgoryRefId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CatgoryCatId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AptechMVCProject.Entity.Cart", b =>
                {
                    b.HasOne("AptechMVCProject.Entity.CartType", "CardType")
                        .WithMany("Carts")
                        .HasForeignKey("CardTypeId");

                    b.HasOne("AptechMVCProject.Entity.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AptechMVCProject.Entity.CartDetails", b =>
                {
                    b.HasOne("AptechMVCProject.Entity.Cart", "Cart")
                        .WithMany("CartDetailses")
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("AptechMVCProject.Entity.ProductListInCart", b =>
                {
                    b.HasOne("AptechMVCProject.Entity.CartDetails", "CartDetails")
                        .WithMany("ProductListInCarts")
                        .HasForeignKey("CartDetailsId");

                    b.HasOne("KerryExample.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("KerryExample.Entity.Product", b =>
                {
                    b.HasOne("KerryExample.Entity.Catgory", "Catgory")
                        .WithMany("Coffees")
                        .HasForeignKey("CatgoryCatId");
                });
#pragma warning restore 612, 618
        }
    }
}
