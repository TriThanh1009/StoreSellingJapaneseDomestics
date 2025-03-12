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
                keyValue: "3ec199b6-eb2b-4df1-bce6-2da956cb8de9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba1c0610-1f45-43be-8c75-2d49639fa462");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 229, DateTimeKind.Local).AddTicks(3346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 784, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 229, DateTimeKind.Local).AddTicks(3168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 783, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 229, DateTimeKind.Local).AddTicks(1490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 783, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 225, DateTimeKind.Local).AddTicks(1383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 779, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2ab8099-daa5-437a-a7b0-bc77feb223e7", null, "Admin", "ADMIN" },
                    { "f22c0e00-5779-41cc-a3b5-286d936d9676", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 3, 11, 1, 57, 46, 230, DateTimeKind.Local).AddTicks(6684), new DateTime(2025, 3, 11, 1, 57, 46, 230, DateTimeKind.Local).AddTicks(6784) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2ab8099-daa5-437a-a7b0-bc77feb223e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f22c0e00-5779-41cc-a3b5-286d936d9676");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 784, DateTimeKind.Local).AddTicks(171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 229, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 783, DateTimeKind.Local).AddTicks(9990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 229, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 783, DateTimeKind.Local).AddTicks(8410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 229, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 11, 1, 57, 40, 779, DateTimeKind.Local).AddTicks(7658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 11, 1, 57, 46, 225, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ec199b6-eb2b-4df1-bce6-2da956cb8de9", null, "Admin", "ADMIN" },
                    { "ba1c0610-1f45-43be-8c75-2d49639fa462", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 3, 11, 1, 57, 40, 785, DateTimeKind.Local).AddTicks(3299), new DateTime(2025, 3, 11, 1, 57, 40, 785, DateTimeKind.Local).AddTicks(3395) });
        }
    }
}
