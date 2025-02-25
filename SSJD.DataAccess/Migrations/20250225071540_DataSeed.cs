using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SSJD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "216e27d9-2200-4593-a4e5-20c2363e8296");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "860ccba2-f310-40ea-87fc-fc14c64b0775");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 519, DateTimeKind.Local).AddTicks(9699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 5, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 519, DateTimeKind.Local).AddTicks(9572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 5, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 519, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 5, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 515, DateTimeKind.Local).AddTicks(7330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 1, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11da4b8d-f72a-4d37-9f5c-f2394f162920", null, "Admin", "ADMIN" },
                    { "eea29d66-8934-4ade-9a89-11eb332a7612", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 15, 40, 521, DateTimeKind.Local).AddTicks(4050), new DateTime(2025, 2, 25, 14, 15, 40, 521, DateTimeKind.Local).AddTicks(4155) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11da4b8d-f72a-4d37-9f5c-f2394f162920");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eea29d66-8934-4ade-9a89-11eb332a7612");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 5, DateTimeKind.Local).AddTicks(6387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 519, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 5, DateTimeKind.Local).AddTicks(6233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 519, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 5, DateTimeKind.Local).AddTicks(4538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 519, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 25, 14, 15, 30, 1, DateTimeKind.Local).AddTicks(7804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 25, 14, 15, 40, 515, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "216e27d9-2200-4593-a4e5-20c2363e8296", null, "Admin", "ADMIN" },
                    { "860ccba2-f310-40ea-87fc-fc14c64b0775", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 15, 30, 6, DateTimeKind.Local).AddTicks(9204), new DateTime(2025, 2, 25, 14, 15, 30, 6, DateTimeKind.Local).AddTicks(9304) });
        }
    }
}
