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
                keyValue: "0dbc9031-6989-4006-9013-6e236ba881af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6801f9e3-c524-42a0-83eb-e6723554eef8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 487, DateTimeKind.Local).AddTicks(6295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 922, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 487, DateTimeKind.Local).AddTicks(6090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 922, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 487, DateTimeKind.Local).AddTicks(4319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 922, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 483, DateTimeKind.Local).AddTicks(5778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 918, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 481, DateTimeKind.Local).AddTicks(8881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 916, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c7293fb-31ca-42b4-aeca-c5008ca3edde", null, "Admin", null },
                    { "c405691c-e893-421e-88f7-c5d76164d8aa", null, "Customer", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f870228e-2bb4-4922-9f45-3698be41ad78", "341ecc37-564a-42eb-9247-0cf6f480bbac" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c7293fb-31ca-42b4-aeca-c5008ca3edde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c405691c-e893-421e-88f7-c5d76164d8aa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 922, DateTimeKind.Local).AddTicks(8220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 487, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 922, DateTimeKind.Local).AddTicks(8069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 487, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 922, DateTimeKind.Local).AddTicks(6272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 487, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 918, DateTimeKind.Local).AddTicks(5408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 483, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 10, 10, 3, 6, 916, DateTimeKind.Local).AddTicks(7475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 10, 10, 3, 15, 481, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0dbc9031-6989-4006-9013-6e236ba881af", null, "Customer", null },
                    { "6801f9e3-c524-42a0-83eb-e6723554eef8", null, "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "896dad3b-eb4b-42ad-ad61-e8877f21ea03", "6403e92c-d239-42bc-8c13-be3cf8ec4488" });
        }
    }
}
