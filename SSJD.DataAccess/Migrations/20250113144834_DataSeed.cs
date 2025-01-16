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
                keyValue: "0d34fec6-5286-41d7-a21d-119cc618b60e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cb7600e-9f31-4996-8995-efc695e315e0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3daacdb4-1088-48f3-b8f0-036c37b1f796");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3daacdb4-1088-48f3-b8f0-036c37b1f796");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 657, DateTimeKind.Local).AddTicks(732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 154, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 656, DateTimeKind.Local).AddTicks(9571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 153, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 656, DateTimeKind.Local).AddTicks(3293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 153, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 637, DateTimeKind.Local).AddTicks(3333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 131, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 624, DateTimeKind.Local).AddTicks(1677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 120, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "603cd653-5497-4ce7-bcc6-0e2f53600ee1", null, "Admin", null },
                    { "61164300-673a-40f3-a8f5-07bab957673d", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f1043639-7efc-4181-a526-4aea5ffe25ff", 0, "5279f791-8997-4346-b756-dfa95f2fef79", null, false, false, null, null, null, null, "123123", false, "7782c353-66e4-438e-bd13-1812df1c92df", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "f1043639-7efc-4181-a526-4aea5ffe25ff", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "603cd653-5497-4ce7-bcc6-0e2f53600ee1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61164300-673a-40f3-a8f5-07bab957673d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "f1043639-7efc-4181-a526-4aea5ffe25ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1043639-7efc-4181-a526-4aea5ffe25ff");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 154, DateTimeKind.Local).AddTicks(353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 657, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 153, DateTimeKind.Local).AddTicks(9404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 656, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 153, DateTimeKind.Local).AddTicks(2393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 656, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 131, DateTimeKind.Local).AddTicks(7113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 637, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 13, 21, 48, 7, 120, DateTimeKind.Local).AddTicks(8170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 13, 21, 48, 31, 624, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d34fec6-5286-41d7-a21d-119cc618b60e", null, "Customer", null },
                    { "5cb7600e-9f31-4996-8995-efc695e315e0", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3daacdb4-1088-48f3-b8f0-036c37b1f796", 0, "135fee1b-f9ea-401b-96d6-c9526db52b75", null, false, false, null, null, null, null, "123123", false, "8c16daef-5cb6-4de6-9f7c-ce7f736c0209", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "3daacdb4-1088-48f3-b8f0-036c37b1f796", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }
    }
}
