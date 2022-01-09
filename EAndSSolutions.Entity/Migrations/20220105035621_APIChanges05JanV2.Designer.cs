﻿// <auto-generated />
using System;
using EAndSSolutions.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EAndSSolutions.Entity.Migrations
{
    [DbContext(typeof(EAndSSolutionsContext))]
    [Migration("20220105035621_APIChanges05JanV2")]
    partial class APIChanges05JanV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EAndSSolutions.Model.EntityModel.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BillTo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(2);

                    b.Property<string>("CaseCoordinator")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(15);

                    b.Property<string>("CaseWorkerEmail")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(24);

                    b.Property<string>("CaseWorkerPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(22);

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(6);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(17);

                    b.Property<string>("ClientID")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(12);

                    b.Property<string>("County")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(18);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(8);

                    b.Property<string>("EmergencyContact")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(23);

                    b.Property<string>("Ethnicity")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(7);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(3);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(13);

                    b.Property<string>("InsurenceID")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(9);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(5);

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(16);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(4);

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoOfChildren")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(10);

                    b.Property<string>("Nurse")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(14);

                    b.Property<string>("ReferredBy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(21);

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(11);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(19);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(25);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(20);

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("EAndSSolutions.Model.EntityModel.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(5);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(13);

                    b.Property<string>("County")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(14);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(20);

                    b.Property<DateTime?>("DateOfFirstCase")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(9);

                    b.Property<DateTime?>("DateOfHire")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(8);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(7);

                    b.Property<string>("EmergencyContact")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(18);

                    b.Property<string>("EmergencyPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(17);

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(10);

                    b.Property<string>("Ethnicity")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(12);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(2);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("HRSupervisor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(11);

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(6);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(4);

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(19);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(3);

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(1);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnOrder(15);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(21);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnOrder(16);

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EAndSSolutions.Model.EntityModel.MasterData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(2);

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MasterDatas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5244),
                            Name = "Male",
                            Type = 1,
                            isActive = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5246),
                            Name = "Female",
                            Type = 1,
                            isActive = true
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5247),
                            Name = "Nurse 1",
                            Type = 4,
                            isActive = true
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5248),
                            Name = "Nurse 2",
                            Type = 4,
                            isActive = true
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5249),
                            Name = "New York",
                            Type = 3,
                            isActive = true
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5250),
                            Name = "Case Coordinator 1",
                            Type = 5,
                            isActive = true
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5251),
                            Name = "Case Coordinator 2",
                            Type = 5,
                            isActive = true
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5252),
                            Name = "HR Supervisor 1",
                            Type = 6,
                            isActive = true
                        },
                        new
                        {
                            Id = 9,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5253),
                            Name = "HR Supervisor 2",
                            Type = 6,
                            isActive = true
                        },
                        new
                        {
                            Id = 10,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5253),
                            Name = "Ethnicity 1",
                            Type = 7,
                            isActive = true
                        },
                        new
                        {
                            Id = 11,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5254),
                            Name = "Ethnicity 2",
                            Type = 7,
                            isActive = true
                        },
                        new
                        {
                            Id = 12,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5255),
                            Name = "Married",
                            Type = 2,
                            isActive = true
                        },
                        new
                        {
                            Id = 13,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5256),
                            Name = "Single",
                            Type = 2,
                            isActive = true
                        },
                        new
                        {
                            Id = 14,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5257),
                            Name = "Divorced",
                            Type = 2,
                            isActive = true
                        },
                        new
                        {
                            Id = 15,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5258),
                            Name = "Separated",
                            Type = 2,
                            isActive = true
                        },
                        new
                        {
                            Id = 16,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5259),
                            Name = "Start of Care",
                            Type = 8,
                            isActive = true
                        },
                        new
                        {
                            Id = 17,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5260),
                            Name = "Admitted Date",
                            Type = 8,
                            isActive = true
                        },
                        new
                        {
                            Id = 18,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5261),
                            Name = "Inquiry",
                            Type = 8,
                            isActive = true
                        },
                        new
                        {
                            Id = 19,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5262),
                            Name = "Discharge",
                            Type = 8,
                            isActive = true
                        },
                        new
                        {
                            Id = 20,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5263),
                            Name = "Inactive",
                            Type = 8,
                            isActive = true
                        },
                        new
                        {
                            Id = 21,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5264),
                            Name = "Active",
                            Type = 8,
                            isActive = true
                        },
                        new
                        {
                            Id = 22,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5265),
                            Name = "Applicant",
                            Type = 9,
                            isActive = true
                        },
                        new
                        {
                            Id = 23,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5266),
                            Name = "Active",
                            Type = 9,
                            isActive = true
                        },
                        new
                        {
                            Id = 24,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5267),
                            Name = "Inactive",
                            Type = 9,
                            isActive = true
                        },
                        new
                        {
                            Id = 25,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5268),
                            Name = "Terminated",
                            Type = 9,
                            isActive = true
                        },
                        new
                        {
                            Id = 26,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5269),
                            Name = "Quit",
                            Type = 9,
                            isActive = true
                        });
                });

            modelBuilder.Entity("EAndSSolutions.Model.EntityModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByIP")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5156),
                            FirstName = "System",
                            LastName = "",
                            Password = "System@1234",
                            UserName = "System@gmail.com",
                            isActive = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
