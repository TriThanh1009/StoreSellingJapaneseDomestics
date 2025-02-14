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
                keyValue: "ab01b3f4-bc98-44ce-aef8-69791215b955");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bed61c95-31f0-459d-9c58-d6d376478532");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "eeccb2a1-14bf-4b0a-a26c-5779b117bbd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeccb2a1-14bf-4b0a-a26c-5779b117bbd7");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 115, DateTimeKind.Local).AddTicks(4131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 565, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 115, DateTimeKind.Local).AddTicks(3979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 565, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 115, DateTimeKind.Local).AddTicks(2439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 564, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 112, DateTimeKind.Local).AddTicks(3387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 561, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 110, DateTimeKind.Local).AddTicks(5528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 560, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "067275d7-40f2-4612-aa6d-4bc23eb90ff7", null, "Admin", "ADMIN" },
                    { "cb513d2a-fe14-417f-a52e-038f135796c1", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52745177-af2f-41c8-b8bd-685ca7a05663", "54e61b43-5931-41ee-8306-6da4070b3675" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0993e09-79a0-4a71-bf86-8fd462c2f682", 0, "381ec344-7be6-45c0-a0b8-1302e09b2fc3", null, false, false, null, null, null, null, "123123", false, "476c07d2-acda-4962-b6c9-37ca2b35830e", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "d0993e09-79a0-4a71-bf86-8fd462c2f682", "1", "Viet Nam", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "067275d7-40f2-4612-aa6d-4bc23eb90ff7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb513d2a-fe14-417f-a52e-038f135796c1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "d0993e09-79a0-4a71-bf86-8fd462c2f682");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0993e09-79a0-4a71-bf86-8fd462c2f682");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 565, DateTimeKind.Local).AddTicks(1881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 115, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 565, DateTimeKind.Local).AddTicks(1730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 115, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 564, DateTimeKind.Local).AddTicks(9637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 115, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 561, DateTimeKind.Local).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 112, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 14, 8, 34, 58, 560, DateTimeKind.Local).AddTicks(2431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 14, 8, 35, 4, 110, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ab01b3f4-bc98-44ce-aef8-69791215b955", null, "Customer", "CUSTOMER" },
                    { "bed61c95-31f0-459d-9c58-d6d376478532", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1ecb6fe-048a-46c8-8986-fd3375891e44", "a3e05428-1b83-4957-bbd0-8a702227b3f0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eeccb2a1-14bf-4b0a-a26c-5779b117bbd7", 0, "6f51daa3-45f8-43d6-a8f1-b93fcd21ab02", null, false, false, null, null, null, null, "123123", false, "83c5e278-a0b8-43ed-b28c-0f90a278d4b5", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "eeccb2a1-14bf-4b0a-a26c-5779b117bbd7", "1", "Viet Nam", "123", "122", "1", 1 });
        }
    }
}
