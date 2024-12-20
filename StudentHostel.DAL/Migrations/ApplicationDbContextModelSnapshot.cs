﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentHostel.DAL.Database;

#nullable disable

namespace StudentHostel.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentHostel.DAL.Entites.Apartment", b =>
                {
                    b.Property<int>("Apartment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Apartment_Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FloorNum")
                        .HasColumnType("int");

                    b.Property<bool>("IsRented")
                        .HasColumnType("bit");

                    b.Property<string>("Location_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Num_Bed")
                        .HasColumnType("int");

                    b.Property<int>("Num_Room")
                        .HasColumnType("int");

                    b.Property<long>("Owner_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Owner_Id1")
                        .HasColumnType("bigint");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Publisheddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Apartment_Id");

                    b.HasIndex("Owner_Id1");

                    b.ToTable("apartments");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Comment", b =>
                {
                    b.Property<int>("Comment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Comment_ID"));

                    b.Property<int?>("Apartment_Id")
                        .HasColumnType("int");

                    b.Property<string>("Comment_Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Comment_ID");

                    b.HasIndex("Apartment_Id");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Owner", b =>
                {
                    b.Property<long>("Owner_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Owner_Id"));

                    b.Property<string>("Owner_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner_FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner_LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Owner_Phone")
                        .HasColumnType("bigint");

                    b.HasKey("Owner_Id");

                    b.ToTable("owners");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Student", b =>
                {
                    b.Property<int>("Student_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Student_Id"));

                    b.Property<int>("Apartment_Id")
                        .HasColumnType("int");

                    b.Property<string>("College")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Student_Phone")
                        .HasColumnType("bigint");

                    b.Property<string>("Student_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_Id");

                    b.HasIndex("Apartment_Id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Apartment", b =>
                {
                    b.HasOne("StudentHostel.DAL.Entites.Owner", "owner")
                        .WithMany("apartments")
                        .HasForeignKey("Owner_Id1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Comment", b =>
                {
                    b.HasOne("StudentHostel.DAL.Entites.Apartment", null)
                        .WithMany("Comments")
                        .HasForeignKey("Apartment_Id");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Student", b =>
                {
                    b.HasOne("StudentHostel.DAL.Entites.Apartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("Apartment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Apartment", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("StudentHostel.DAL.Entites.Owner", b =>
                {
                    b.Navigation("apartments");
                });
#pragma warning restore 612, 618
        }
    }
}
