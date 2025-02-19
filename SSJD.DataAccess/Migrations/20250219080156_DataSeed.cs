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
                keyValue: "16d1a409-32a7-409b-ba39-1620ffeaccf3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9af98741-517d-46ba-a0e6-d06624d8c9e5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 961, DateTimeKind.Local).AddTicks(4198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 602, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 961, DateTimeKind.Local).AddTicks(4033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 602, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 961, DateTimeKind.Local).AddTicks(2211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 602, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 958, DateTimeKind.Local).AddTicks(1957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 599, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 956, DateTimeKind.Local).AddTicks(3644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 596, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d04f4a6b-caa6-442f-a8e8-bafc9fb0e8e9", null, "Customer", "CUSTOMER" },
                    { "fdde72db-0a2a-421c-9479-95c8387efb20", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d04f4a6b-caa6-442f-a8e8-bafc9fb0e8e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdde72db-0a2a-421c-9479-95c8387efb20");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 602, DateTimeKind.Local).AddTicks(4628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 961, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 602, DateTimeKind.Local).AddTicks(4508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 961, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 602, DateTimeKind.Local).AddTicks(2816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 961, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 599, DateTimeKind.Local).AddTicks(907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 958, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 15, 1, 51, 596, DateTimeKind.Local).AddTicks(9349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 15, 1, 55, 956, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16d1a409-32a7-409b-ba39-1620ffeaccf3", null, "Customer", "CUSTOMER" },
                    { "9af98741-517d-46ba-a0e6-d06624d8c9e5", null, "Admin", "ADMIN" }
                });
        }
    }
}
