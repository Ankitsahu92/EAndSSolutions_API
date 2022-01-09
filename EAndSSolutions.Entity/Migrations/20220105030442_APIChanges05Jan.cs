using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EAndSSolutions.Entity.Migrations
{
    public partial class APIChanges05Jan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfHire",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfFirstCase",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.InsertData(
                table: "MasterDatas",
                columns: new[] { "Id", "CreatedBy", "CreatedByIP", "CreatedOn", "ModifiedBy", "ModifiedByIP", "ModifiedOn", "Name", "Type", "isActive" },
                values: new object[,]
                {
                    { 16, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4833), null, null, null, "Start of Care", 8, true },
                    { 17, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4834), null, null, null, "Admitted Date", 8, true },
                    { 18, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4835), null, null, null, "Inquiry", 8, true },
                    { 19, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4836), null, null, null, "Discharge", 8, true },
                    { 20, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4838), null, null, null, "Inactive", 8, true },
                    { 21, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4839), null, null, null, "Active", 8, true },
                    { 22, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4865), null, null, null, "Applicant", 9, true },
                    { 23, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4866), null, null, null, "Active", 9, true },
                    { 24, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4867), null, null, null, "Inactive", 9, true },
                    { 25, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4868), null, null, null, "Terminated", 9, true },
                    { 26, 1, null, new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4869), null, null, null, "Quit", 9, true }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4735));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfHire",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfFirstCase",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 3, 21, 0, 46, 931, DateTimeKind.Local).AddTicks(9804));
        }
    }
}
