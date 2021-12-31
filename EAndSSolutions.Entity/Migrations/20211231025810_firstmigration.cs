using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EAndSSolutions.Entity.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsurenceID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfChildren = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nurse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseCoordinator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferredBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseWorkerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseWorkerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfHire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfFirstCase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HRSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MasterDatas",
                columns: new[] { "Id", "CreatedBy", "CreatedByIP", "CreatedOn", "ModifiedBy", "ModifiedByIP", "ModifiedOn", "Name", "Type", "isActive" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5051), null, null, null, "Male", 1, true },
                    { 2, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5052), null, null, null, "Female", 1, true },
                    { 3, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5091), null, null, null, "Nurse 1", 4, true },
                    { 4, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5093), null, null, null, "Nurse 2", 4, true },
                    { 5, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5094), null, null, null, "New York", 3, true },
                    { 6, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5095), null, null, null, "Case Coordinator 1", 5, true },
                    { 7, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5096), null, null, null, "Case Coordinator 2", 5, true },
                    { 8, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5097), null, null, null, "HR Supervisor 1", 6, true },
                    { 9, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5099), null, null, null, "HR Supervisor 2", 6, true },
                    { 10, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5100), null, null, null, "Ethnicity 1", 7, true },
                    { 11, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(5101), null, null, null, "Ethnicity 2", 7, true }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedByIP", "CreatedOn", "FirstName", "LastName", "ModifiedBy", "ModifiedByIP", "ModifiedOn", "Password", "UserName", "isActive" },
                values: new object[] { 1, 1, null, new DateTime(2021, 12, 31, 8, 28, 10, 731, DateTimeKind.Local).AddTicks(4939), "System", "", null, null, null, "System@1234", "System@gmail.com", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "MasterDatas");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
