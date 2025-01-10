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
                keyValue: "5c321b49-7d26-4892-976c-6ff6282d37b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b209c315-e88d-471b-982a-d2c8b49b90ca");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "2b9e005c-c9a0-4a11-8117-295b9503324b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b9e005c-c9a0-4a11-8117-295b9503324b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 420, DateTimeKind.Local).AddTicks(2001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 985, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 420, DateTimeKind.Local).AddTicks(1517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 985, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 419, DateTimeKind.Local).AddTicks(5959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 985, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 408, DateTimeKind.Local).AddTicks(6037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 971, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 404, DateTimeKind.Local).AddTicks(1953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 941, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a0fd5499-b31e-4737-976a-52b3c99596bf", null, "Admin", null },
                    { "dd81ce62-d468-4540-9675-00563beb14db", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "10b10369-2b3f-40c9-8cbd-8faca4a3ee48", 0, "4ed2c47a-599a-45fe-8c2e-352fb35e4267", null, false, false, null, null, null, null, "123123", false, "97f3af96-7c47-4095-813f-71b4464bdda8", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "10b10369-2b3f-40c9-8cbd-8faca4a3ee48", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fd5499-b31e-4737-976a-52b3c99596bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd81ce62-d468-4540-9675-00563beb14db");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "10b10369-2b3f-40c9-8cbd-8faca4a3ee48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10b10369-2b3f-40c9-8cbd-8faca4a3ee48");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 985, DateTimeKind.Local).AddTicks(4208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 420, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 985, DateTimeKind.Local).AddTicks(3834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 420, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 985, DateTimeKind.Local).AddTicks(132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 419, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 971, DateTimeKind.Local).AddTicks(1848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 408, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 8, 21, 39, 8, 941, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 8, 21, 39, 37, 404, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c321b49-7d26-4892-976c-6ff6282d37b2", null, "Admin", null },
                    { "b209c315-e88d-471b-982a-d2c8b49b90ca", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2b9e005c-c9a0-4a11-8117-295b9503324b", 0, "ebbe7708-714d-475e-9770-ca54491b6241", null, false, false, null, null, null, null, "123123", false, "c9d9aa5b-5ee3-4dd2-8b82-858d4ff7d120", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "2b9e005c-c9a0-4a11-8117-295b9503324b", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }
    }
}
