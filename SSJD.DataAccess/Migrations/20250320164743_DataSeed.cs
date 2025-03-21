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
                keyValue: "0e664dc6-09de-432b-9cd2-6e1352966346");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5fb823a-eb3e-4706-9b11-d542baec875a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 420, DateTimeKind.Local).AddTicks(1958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 767, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 420, DateTimeKind.Local).AddTicks(1794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 767, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 420, DateTimeKind.Local).AddTicks(261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 767, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 415, DateTimeKind.Local).AddTicks(7259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 762, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "120c7df3-a851-4dfe-b12d-78c0ca0e918d", null, "Customer", "CUSTOMER" },
                    { "cb7b87c9-7256-456c-acee-8be53b44ec9d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43428863-576f-4a2d-aa3a-9c7fc02e5358", "5d93e6a4-f817-4dd8-a6d2-0d85099961cd" });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 3, 20, 23, 47, 43, 421, DateTimeKind.Local).AddTicks(6823), new DateTime(2025, 3, 20, 23, 47, 43, 421, DateTimeKind.Local).AddTicks(6910) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "120c7df3-a851-4dfe-b12d-78c0ca0e918d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb7b87c9-7256-456c-acee-8be53b44ec9d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 767, DateTimeKind.Local).AddTicks(5267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 420, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 767, DateTimeKind.Local).AddTicks(5099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 420, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 767, DateTimeKind.Local).AddTicks(3438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 420, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 20, 23, 47, 4, 762, DateTimeKind.Local).AddTicks(8843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 20, 23, 47, 43, 415, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e664dc6-09de-432b-9cd2-6e1352966346", null, "Admin", "ADMIN" },
                    { "b5fb823a-eb3e-4706-9b11-d542baec875a", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "497cae09-50ac-4d57-9b33-5c5431627093", "ce5f5587-e4ec-4f1c-a716-00e5035be024" });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2025, 3, 20, 23, 47, 4, 769, DateTimeKind.Local).AddTicks(847), new DateTime(2025, 3, 20, 23, 47, 4, 769, DateTimeKind.Local).AddTicks(941) });
        }
    }
}
