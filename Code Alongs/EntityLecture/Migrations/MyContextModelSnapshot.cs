﻿// <auto-generated />
using System;
using EntityLecture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityLecture.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EntityLecture.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EntityLecture.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLecture.Models.Post", b =>
                {
                    b.HasOne("EntityLecture.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });
#pragma warning restore 612, 618
        }
    }
}
