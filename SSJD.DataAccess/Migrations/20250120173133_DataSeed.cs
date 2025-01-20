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
                keyValue: "e73b9587-bb9c-4099-b85b-971689347b49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe773bd2-81b5-484b-bc85-fd4cb3c07d35");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "94bb0740-5e89-4e1b-9091-c8fe2c8f65e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94bb0740-5e89-4e1b-9091-c8fe2c8f65e2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 86, DateTimeKind.Local).AddTicks(9183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 462, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 86, DateTimeKind.Local).AddTicks(9051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 462, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 86, DateTimeKind.Local).AddTicks(7651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 462, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 82, DateTimeKind.Local).AddTicks(9014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 458, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 81, DateTimeKind.Local).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 447, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c0b0edd-97ed-485e-8d92-175d1bd0f425", null, "Customer", null },
                    { "3e089286-5e25-40a4-82ea-6c3f7c72f752", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5dfa1df9-22b4-4d0c-bd32-9bd05240c512", 0, "cf56b58e-b3bf-49e8-ad66-8ce57e1d8069", null, false, false, null, null, null, null, "123123", false, "a47f8128-bf88-49b1-8164-690341ad8e85", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "5dfa1df9-22b4-4d0c-bd32-9bd05240c512", "1", "Viet Nam", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c0b0edd-97ed-485e-8d92-175d1bd0f425");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e089286-5e25-40a4-82ea-6c3f7c72f752");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfa1df9-22b4-4d0c-bd32-9bd05240c512");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dfa1df9-22b4-4d0c-bd32-9bd05240c512");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 462, DateTimeKind.Local).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 86, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 462, DateTimeKind.Local).AddTicks(5297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 86, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 462, DateTimeKind.Local).AddTicks(3672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 86, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 458, DateTimeKind.Local).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 82, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 21, 0, 31, 21, 447, DateTimeKind.Local).AddTicks(8692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 21, 0, 31, 33, 81, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e73b9587-bb9c-4099-b85b-971689347b49", null, "Admin", null },
                    { "fe773bd2-81b5-484b-bc85-fd4cb3c07d35", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "94bb0740-5e89-4e1b-9091-c8fe2c8f65e2", 0, "57a60b5b-8518-43d4-87f4-61961883a725", null, false, false, null, null, null, null, "123123", false, "75fa0e6b-ab32-4fcb-a58f-7b793fc99800", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "94bb0740-5e89-4e1b-9091-c8fe2c8f65e2", "1", "Viet Nam", "123", "122", "1", 1 });
        }
    }
}
