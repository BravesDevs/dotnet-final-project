﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Petstore_GroupProject8.Models;

#nullable disable

namespace Petstore_GroupProject8.Migrations
{
    [DbContext(typeof(PetStoreDbContext))]
    [Migration("20241122191803_PetstoreInitial")]
    partial class PetstoreInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Food",
                            Description = "Pet food and treats"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Toys",
                            Description = "Toys for pets"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Accessories",
                            Description = "Pet accessories such as leashes, collars, etc."
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Grooming",
                            Description = "Grooming supplies for pets"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Healthcare",
                            Description = "Healthcare products for pets"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Beds & Furniture",
                            Description = "Pet beds and furniture"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Training",
                            Description = "Training supplies for pets"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Clothing",
                            Description = "Clothing for pets"
                        });
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerUnit")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("StockQuantity")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Premium dry dog food for all breeds",
                            ImageUrl = "dry_dog_food.jpg",
                            Name = "Dry Dog Food",
                            Price = 29.99m,
                            StockQuantity = "100"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Description = "Fun mouse toy for cats",
                            ImageUrl = "cat_toy_mouse.jpg",
                            Name = "Cat Toy Mouse",
                            Price = 4.99m,
                            StockQuantity = "200"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            Description = "Durable leash for dogs",
                            ImageUrl = "dog_leash.jpg",
                            Name = "Dog Leash",
                            Price = 14.99m,
                            StockQuantity = "150"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4,
                            Description = "Gentle pet shampoo for grooming",
                            ImageUrl = "pet_shampoo.jpg",
                            Name = "Pet Shampoo",
                            Price = 9.99m,
                            StockQuantity = "120"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 6,
                            Description = "Comfortable bed for dogs",
                            ImageUrl = "dog_bed.jpg",
                            Name = "Dog Bed",
                            Price = 39.99m,
                            StockQuantity = "80"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            Description = "Scratching post to keep cats entertained",
                            ImageUrl = "cat_scratching_post.jpg",
                            Name = "Cat Scratching Post",
                            Price = 24.99m,
                            StockQuantity = "60"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 5,
                            Description = "First aid kit for pets",
                            ImageUrl = "pet_first_aid_kit.jpg",
                            Name = "Pet First Aid Kit",
                            Price = 19.99m,
                            StockQuantity = "50"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 7,
                            Description = "Training pads for puppies",
                            ImageUrl = "training_pads.jpg",
                            Name = "Training Pads",
                            Price = 15.99m,
                            StockQuantity = "90"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            Description = "Adjustable collar for cats",
                            ImageUrl = "cat_collar.jpg",
                            Name = "Cat Collar",
                            Price = 7.99m,
                            StockQuantity = "140"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 8,
                            Description = "Warm sweater for small dogs",
                            ImageUrl = "dog_sweater.jpg",
                            Name = "Dog Sweater",
                            Price = 12.99m,
                            StockQuantity = "70"
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1,
                            Description = "Nutritious mix for pet birds",
                            ImageUrl = "bird_food_mix.jpg",
                            Name = "Bird Food Mix",
                            Price = 8.99m,
                            StockQuantity = "110"
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            Description = "Nail clippers for grooming pets",
                            ImageUrl = "pet_nail_clippers.jpg",
                            Name = "Pet Nail Clippers",
                            Price = 6.99m,
                            StockQuantity = "100"
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 7,
                            Description = "Whistle for dog training",
                            ImageUrl = "dog_training_whistle.jpg",
                            Name = "Dog Training Whistle",
                            Price = 5.99m,
                            StockQuantity = "130"
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 3,
                            Description = "Decorations for fish tanks",
                            ImageUrl = "fish_tank_decorations.jpg",
                            Name = "Fish Tank Decorations",
                            Price = 11.99m,
                            StockQuantity = "85"
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 6,
                            Description = "Soft bed for cats",
                            ImageUrl = "cat_bed.jpg",
                            Name = "Cat Bed",
                            Price = 25.99m,
                            StockQuantity = "75"
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 5,
                            Description = "Vitamins for pets to maintain health",
                            ImageUrl = "pet_vitamins.jpg",
                            Name = "Pet Vitamins",
                            Price = 13.99m,
                            StockQuantity = "95"
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 3,
                            Description = "Comfortable harness for dogs",
                            ImageUrl = "dog_harness.jpg",
                            Name = "Dog Harness",
                            Price = 18.99m,
                            StockQuantity = "60"
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 4,
                            Description = "Brush for grooming cats",
                            ImageUrl = "cat_grooming_brush.jpg",
                            Name = "Cat Grooming Brush",
                            Price = 9.49m,
                            StockQuantity = "125"
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 2,
                            Description = "Exercise wheel for hamsters",
                            ImageUrl = "hamster_wheel.jpg",
                            Name = "Hamster Wheel",
                            Price = 14.49m,
                            StockQuantity = "50"
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 8,
                            Description = "Raincoat for dogs",
                            ImageUrl = "dog_raincoat.jpg",
                            Name = "Dog Raincoat",
                            Price = 16.99m,
                            StockQuantity = "45"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Petstore_GroupProject8.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Petstore_GroupProject8.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petstore_GroupProject8.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Petstore_GroupProject8.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Order", b =>
                {
                    b.HasOne("Petstore_GroupProject8.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.OrderItem", b =>
                {
                    b.HasOne("Petstore_GroupProject8.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petstore_GroupProject8.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Payment", b =>
                {
                    b.HasOne("Petstore_GroupProject8.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Product", b =>
                {
                    b.HasOne("Petstore_GroupProject8.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Petstore_GroupProject8.Models.Product", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}