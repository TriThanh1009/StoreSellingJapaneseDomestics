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
                keyValue: "8ab06fcc-e289-47d8-a7ef-90edac6ddde1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0a16fe0-3b30-4da5-a7b1-69ed7866d75b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 73, DateTimeKind.Local).AddTicks(3032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 68, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 73, DateTimeKind.Local).AddTicks(2911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 68, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 73, DateTimeKind.Local).AddTicks(1366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 68, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 70, DateTimeKind.Local).AddTicks(727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 65, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 68, DateTimeKind.Local).AddTicks(3505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 64, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e8a5ac8-54d7-432a-9f38-91183065164e", null, "Admin", "ADMIN" },
                    { "3830cad6-e32b-479b-a903-7c8bc756aa3c", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e8a5ac8-54d7-432a-9f38-91183065164e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3830cad6-e32b-479b-a903-7c8bc756aa3c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 68, DateTimeKind.Local).AddTicks(7847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 73, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 68, DateTimeKind.Local).AddTicks(7688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 73, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 68, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 73, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 65, DateTimeKind.Local).AddTicks(6999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 70, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 18, 21, 0, 64, DateTimeKind.Local).AddTicks(334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 18, 21, 6, 68, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ab06fcc-e289-47d8-a7ef-90edac6ddde1", null, "Customer", "CUSTOMER" },
                    { "c0a16fe0-3b30-4da5-a7b1-69ed7866d75b", null, "Admin", "ADMIN" }
                });
        }
    }
}
