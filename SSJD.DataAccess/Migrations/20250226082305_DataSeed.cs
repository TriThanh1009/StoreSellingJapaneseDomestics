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
                keyValue: "82809fa2-9560-4381-aba6-b6d386399d84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb7a1571-06e8-4769-b744-3d97b7cbd832");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 359, DateTimeKind.Local).AddTicks(3688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 906, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 359, DateTimeKind.Local).AddTicks(3530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 906, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 359, DateTimeKind.Local).AddTicks(1826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 906, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 355, DateTimeKind.Local).AddTicks(2417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 902, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b2debd2-0005-4235-b9a6-444545c03391", null, "Admin", "ADMIN" },
                    { "aaad981f-302c-4648-a182-52961567c593", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 23, 5, 360, DateTimeKind.Local).AddTicks(8681), new DateTime(2025, 2, 26, 15, 23, 5, 360, DateTimeKind.Local).AddTicks(8773) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b2debd2-0005-4235-b9a6-444545c03391");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaad981f-302c-4648-a182-52961567c593");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 906, DateTimeKind.Local).AddTicks(7830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 359, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 906, DateTimeKind.Local).AddTicks(7674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 359, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 906, DateTimeKind.Local).AddTicks(5985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 359, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 15, 22, 58, 902, DateTimeKind.Local).AddTicks(6188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 15, 23, 5, 355, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82809fa2-9560-4381-aba6-b6d386399d84", null, "Customer", "CUSTOMER" },
                    { "cb7a1571-06e8-4769-b744-3d97b7cbd832", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 22, 58, 908, DateTimeKind.Local).AddTicks(795), new DateTime(2025, 2, 26, 15, 22, 58, 908, DateTimeKind.Local).AddTicks(893) });
        }
    }
}
