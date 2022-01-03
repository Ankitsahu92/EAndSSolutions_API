using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EAndSSolutions.Entity.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillTo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    InsurenceID = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NoOfChildren = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ClientID = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Nurse = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CaseCoordinator = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    County = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    State = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ReferredBy = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CaseWorkerPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CaseWorkerEmail = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
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
                    SSN = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DateOfHire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfFirstCase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    HRSupervisor = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    County = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    State = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmergencyPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
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
                    CreatedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
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
                    CreatedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByIP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
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
                    { 1, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9919), null, null, null, "Male", 1, true },
                    { 2, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9921), null, null, null, "Female", 1, true },
                    { 3, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9922), null, null, null, "Nurse 1", 4, true },
                    { 4, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9923), null, null, null, "Nurse 2", 4, true },
                    { 5, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9924), null, null, null, "New York", 3, true },
                    { 6, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9925), null, null, null, "Case Coordinator 1", 5, true },
                    { 7, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9926), null, null, null, "Case Coordinator 2", 5, true },
                    { 8, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9927), null, null, null, "HR Supervisor 1", 6, true },
                    { 9, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9928), null, null, null, "HR Supervisor 2", 6, true },
                    { 10, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9929), null, null, null, "Ethnicity 1", 7, true },
                    { 11, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9930), null, null, null, "Ethnicity 2", 7, true },
                    { 12, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9932), null, null, null, "Married", 2, true },
                    { 13, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9933), null, null, null, "Single", 2, true },
                    { 14, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9934), null, null, null, "Divorced", 2, true },
                    { 15, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9935), null, null, null, "Separated", 2, true }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedByIP", "CreatedOn", "FirstName", "LastName", "ModifiedBy", "ModifiedByIP", "ModifiedOn", "Password", "UserName", "isActive" },
                values: new object[] { 1, 1, null, new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9804), "System", "", null, null, null, "System@1234", "System@gmail.com", true });
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
