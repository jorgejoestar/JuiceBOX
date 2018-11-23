﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webshop.Models;

namespace Webshop.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20181123084437_DbSeed")]
    partial class DbSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Webshop.Models.Cart", b =>
                {
                    b.Property<long>("CartID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductAmount");

                    b.Property<string>("UserId");

                    b.HasKey("CartID");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Webshop.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CartID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Imagepath")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.HasKey("ProductID");

                    b.HasIndex("CartID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ProductID = 1L, Description = "consequatur", Imagepath = "http://lorempixel.com/640/480/abstract", Name = "Unbranded Wooden Pants", Price = 61.2659352963166, Stock = 423 },
                        new { ProductID = 2L, Description = "Tempore molestiae quam est.", Imagepath = "http://lorempixel.com/640/480/cats", Name = "Practical Steel Table", Price = 88.180290637156133, Stock = 649 },
                        new { ProductID = 3L, Description = @"Odit ut sapiente repellat distinctio reprehenderit magni est.
Iure explicabo et sed delectus ut consequatur.
Aut modi quae eaque et repudiandae aliquam labore.
Consequuntur asperiores suscipit hic debitis deleniti ducimus dicta dolores.
Rem perferendis dolor repudiandae amet ducimus ipsum sed voluptas quasi.", Imagepath = "http://lorempixel.com/640/480/nightlife", Name = "Awesome Rubber Keyboard", Price = 203.51949980553218, Stock = 683 },
                        new { ProductID = 4L, Description = "Nobis eaque et nihil possimus ut ut eos.", Imagepath = "http://lorempixel.com/640/480/nightlife", Name = "Intelligent Soft Table", Price = 97.950680721993876, Stock = 556 },
                        new { ProductID = 5L, Description = "Soluta adipisci nemo vero officia. Autem molestiae dolorem hic dignissimos temporibus natus dolores consequatur ipsum. Ea aspernatur magnam voluptas aliquam aut est quae veritatis. Accusantium porro et commodi at id odio.", Imagepath = "http://lorempixel.com/640/480/food", Name = "Sleek Rubber Mouse", Price = 193.13963273639774, Stock = 317 },
                        new { ProductID = 6L, Description = "Officia tenetur qui aliquid eum veritatis eos odio qui.", Imagepath = "http://lorempixel.com/640/480/animals", Name = "Small Fresh Computer", Price = 12.204744549563502, Stock = 733 },
                        new { ProductID = 7L, Description = @"Veniam ut non voluptatem qui officia illo.
Quisquam illo ipsum.
Enim tenetur repellat maiores libero non dolorem optio incidunt omnis.
Ad excepturi voluptatem quia occaecati accusamus nisi consequatur laboriosam aut.
Vero et similique voluptas consequatur ut ullam.
Laboriosam dicta ut dignissimos id omnis eius qui.", Imagepath = "http://lorempixel.com/640/480/city", Name = "Intelligent Rubber Table", Price = 190.06299128060368, Stock = 385 },
                        new { ProductID = 8L, Description = "Facere voluptatem totam provident magnam autem quae eum earum maxime.", Imagepath = "http://lorempixel.com/640/480/nature", Name = "Refined Wooden Gloves", Price = 25.029448359752745, Stock = 91 },
                        new { ProductID = 9L, Description = "Non quibusdam aut et qui nisi ullam.", Imagepath = "http://lorempixel.com/640/480/fashion", Name = "Practical Plastic Towels", Price = 71.474695451313025, Stock = 587 },
                        new { ProductID = 10L, Description = "dignissimos", Imagepath = "http://lorempixel.com/640/480/cats", Name = "Generic Granite Salad", Price = 159.48981031053225, Stock = 574 }
                    );
                });

            modelBuilder.Entity("Webshop.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<long>("UserID");

                    b.ToTable("User");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new { Id = "374f4644-8ec9-468a-92b8-fe7a8b1ea95b", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 1L },
                        new { Id = "29b1f971-639f-4d24-8d81-ac2b64125502", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 2L },
                        new { Id = "80c724bc-80a4-4834-8e6e-43dc15111f13", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 3L },
                        new { Id = "53624c26-bc14-45a8-a80c-1474aec2f0db", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 4L },
                        new { Id = "4776f2a5-5d25-41d1-a902-946973106ebb", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 5L },
                        new { Id = "54916c64-a5da-4367-95c9-faa2db5bbe9b", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 6L },
                        new { Id = "ee90d9ba-8dd3-4dc7-b87d-8985829e88d7", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 7L },
                        new { Id = "01e4e618-d176-49e2-aa96-2444895b8980", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 8L },
                        new { Id = "83b480dc-dac3-4dcd-9bf5-9b821f938db0", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 9L },
                        new { Id = "4db2520a-1c51-4b2f-bec4-925a75c6843f", AccessFailedCount = 0, EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = true, TwoFactorEnabled = false, UserID = 10L }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Webshop.Models.Cart", b =>
                {
                    b.HasOne("Webshop.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Webshop.Models.Product", b =>
                {
                    b.HasOne("Webshop.Models.Cart")
                        .WithMany("Products")
                        .HasForeignKey("CartID");
                });
#pragma warning restore 612, 618
        }
    }
}
