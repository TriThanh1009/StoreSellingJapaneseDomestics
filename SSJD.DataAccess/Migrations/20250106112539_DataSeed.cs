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
                keyValue: "0d2cb443-cfa1-4308-b4ae-f68694d73ee9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53ed45bb-5dd0-4f9c-b9ae-6896db00fa35");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "17e6adf6-c756-41d3-9158-2c83678bb2a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e6adf6-c756-41d3-9158-2c83678bb2a5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 865, DateTimeKind.Local).AddTicks(6256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 942, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 865, DateTimeKind.Local).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 942, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 865, DateTimeKind.Local).AddTicks(3033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 941, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 860, DateTimeKind.Local).AddTicks(8309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 936, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 857, DateTimeKind.Local).AddTicks(6710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 928, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52afbd4f-4e7f-4fec-85a1-9011e8d323d7", null, "Admin", null },
                    { "9c7a9e9a-c24c-4eba-9c79-4135b40eccb0", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "952d2073-c0f1-481b-9638-29a888d6b246", 0, "f4149b4f-da9b-464b-be3f-6e80e446d2ef", null, false, false, null, null, null, null, "123123", false, "7e60b44f-8003-4897-a5ec-602b0ff6bc43", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "952d2073-c0f1-481b-9638-29a888d6b246", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52afbd4f-4e7f-4fec-85a1-9011e8d323d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c7a9e9a-c24c-4eba-9c79-4135b40eccb0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "952d2073-c0f1-481b-9638-29a888d6b246");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "952d2073-c0f1-481b-9638-29a888d6b246");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 942, DateTimeKind.Local).AddTicks(2706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 865, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 942, DateTimeKind.Local).AddTicks(2394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 865, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 941, DateTimeKind.Local).AddTicks(9261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 865, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 936, DateTimeKind.Local).AddTicks(5726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 860, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 6, 18, 25, 27, 928, DateTimeKind.Local).AddTicks(7211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 6, 18, 25, 38, 857, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d2cb443-cfa1-4308-b4ae-f68694d73ee9", null, "Customer", null },
                    { "53ed45bb-5dd0-4f9c-b9ae-6896db00fa35", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "17e6adf6-c756-41d3-9158-2c83678bb2a5", 0, "e91a859f-2ae3-4bfc-8cda-1a62fcf7eb16", null, false, false, null, null, null, null, "123123", false, "81002f3e-03d0-4fea-a28e-6316a1176cd0", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "17e6adf6-c756-41d3-9158-2c83678bb2a5", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }
    }
}
