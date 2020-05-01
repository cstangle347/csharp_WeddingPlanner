﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeddingPlanner.Models;

namespace WeddingPlanner.Migrations
{
    [DbContext(typeof(WeddingContext))]
    partial class WeddingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("weddingPlanner.Models.Invite", b =>
                {
                    b.Property<int>("InviteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.Property<int>("WeddingId");

                    b.HasKey("InviteId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeddingId");

                    b.ToTable("Invites");
                });

            modelBuilder.Entity("weddingPlanner.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int?>("UserId1");

                    b.HasKey("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("weddingPlanner.Models.Wedding", b =>
                {
                    b.Property<int>("WeddingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("SpouseOne")
                        .IsRequired();

                    b.Property<string>("SpouseTwo")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<DateTime>("WeddingDate");

                    b.Property<int?>("WeddingId1");

                    b.HasKey("WeddingId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeddingId1");

                    b.ToTable("Weddings");
                });

            modelBuilder.Entity("weddingPlanner.Models.Invite", b =>
                {
                    b.HasOne("weddingPlanner.Models.User", "Guest")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("weddingPlanner.Models.Wedding", "Party")
                        .WithMany()
                        .HasForeignKey("WeddingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("weddingPlanner.Models.User", b =>
                {
                    b.HasOne("weddingPlanner.Models.User")
                        .WithMany("Guest")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("weddingPlanner.Models.Wedding", b =>
                {
                    b.HasOne("weddingPlanner.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("weddingPlanner.Models.Wedding")
                        .WithMany("Party")
                        .HasForeignKey("WeddingId1");
                });
#pragma warning restore 612, 618
        }
    }
}