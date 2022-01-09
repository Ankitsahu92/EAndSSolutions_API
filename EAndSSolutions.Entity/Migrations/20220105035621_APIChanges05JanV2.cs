using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EAndSSolutions.Entity.Migrations
{
    public partial class APIChanges05JanV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 21);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 25);

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 9, 26, 20, 950, DateTimeKind.Local).AddTicks(5156));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Client");

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

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "MasterDatas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 5, 8, 34, 41, 980, DateTimeKind.Local).AddTicks(4735));
        }
    }
}
