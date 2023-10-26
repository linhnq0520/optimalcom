﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Optimal.Com.Web.Framework.Data;

#nullable disable

namespace Optimal.Com.Web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231006100251_CodelistTable")]
    partial class CodelistTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Optimal.Com.Web.Data.Entities.AbsenceForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AbsenceFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AbsenceToDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AbsenceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("ApproveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PersonApprove")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ReasonAbsence")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("TotalAbsenceDay")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AbsenceForm");
                });

            modelBuilder.Entity("Optimal.Com.Web.Data.Entities.Codelist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CodeGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CodeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Codelist");
                });

            modelBuilder.Entity("Optimal.Com.Web.Data.Entities.User", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BranchCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DaysOffUsed")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("RemainingDaysOff")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("UserID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
