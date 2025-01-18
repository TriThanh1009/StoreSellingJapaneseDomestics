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
                keyValue: "0a007bb0-3c01-4214-bc0a-1f5b28723f10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64024452-44f9-44e1-bfa4-5a6678ab6a1a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b7671dac-c5cb-4b41-ac35-cdcc73d5b87b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7671dac-c5cb-4b41-ac35-cdcc73d5b87b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 999, DateTimeKind.Local).AddTicks(7797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 110, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 999, DateTimeKind.Local).AddTicks(7629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 110, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 999, DateTimeKind.Local).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 109, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 994, DateTimeKind.Local).AddTicks(3537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 106, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 992, DateTimeKind.Local).AddTicks(1342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 104, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "198878f5-228e-420c-a6e6-092ab6e26caa", null, "Customer", null },
                    { "e146d555-2c32-475d-b0b9-2d6b5ffa2c06", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc8b4574-32a6-4c29-9134-46a2c004595b", 0, "57f6052d-5fdd-4a3c-8fe9-9425bf931bf7", null, false, false, null, null, null, null, "123123", false, "41513ab0-9ae2-48ed-8175-43fc8b655123", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "dc8b4574-32a6-4c29-9134-46a2c004595b", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "198878f5-228e-420c-a6e6-092ab6e26caa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e146d555-2c32-475d-b0b9-2d6b5ffa2c06");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "dc8b4574-32a6-4c29-9134-46a2c004595b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc8b4574-32a6-4c29-9134-46a2c004595b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 110, DateTimeKind.Local).AddTicks(154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 999, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 110, DateTimeKind.Local).AddTicks(28),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 999, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 109, DateTimeKind.Local).AddTicks(8493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 999, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 106, DateTimeKind.Local).AddTicks(1141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 994, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 20, 8, 28, 104, DateTimeKind.Local).AddTicks(3560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 20, 9, 5, 992, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a007bb0-3c01-4214-bc0a-1f5b28723f10", null, "Customer", null },
                    { "64024452-44f9-44e1-bfa4-5a6678ab6a1a", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b7671dac-c5cb-4b41-ac35-cdcc73d5b87b", 0, "cdf83f6c-a3de-4b0a-b5ab-767dcb3e9e2a", null, false, false, null, null, null, null, "123123", false, "16915e00-f20e-4421-a6c8-ec60aa196801", false, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "b7671dac-c5cb-4b41-ac35-cdcc73d5b87b", "1", "Viet Nam", "Nguyen Tri Thanh", "123", "122", "1", 1 });
        }
    }
}
