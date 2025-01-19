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
                keyValue: "80da2dbf-d84e-4e92-a507-f19bd5beb2d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d73e7091-3eaa-4c5b-8faf-e982366fe18e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "393bd9fd-e9d2-4208-9e6a-5837af7fcd42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "393bd9fd-e9d2-4208-9e6a-5837af7fcd42");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 994, DateTimeKind.Local).AddTicks(5892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 148, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 994, DateTimeKind.Local).AddTicks(5738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 148, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 994, DateTimeKind.Local).AddTicks(4179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 148, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 990, DateTimeKind.Local).AddTicks(5225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 143, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 988, DateTimeKind.Local).AddTicks(5639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 141, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18ba79ca-adec-4bbf-9599-b1b95c16af51", null, "Customer", null },
                    { "af5ed956-5c18-4124-b166-73a622f04a57", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a30bca6e-4346-442a-83ec-18e05c162418", 0, "8c320cdc-01bc-47b4-85e7-68d16275096d", null, false, false, null, null, null, null, "123123", false, "bedb7d9f-7149-4c0d-8e58-3307c9d8f430", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "a30bca6e-4346-442a-83ec-18e05c162418", "1", "Viet Nam", "", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18ba79ca-adec-4bbf-9599-b1b95c16af51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af5ed956-5c18-4124-b166-73a622f04a57");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a30bca6e-4346-442a-83ec-18e05c162418");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a30bca6e-4346-442a-83ec-18e05c162418");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 148, DateTimeKind.Local).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 994, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 148, DateTimeKind.Local).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 994, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 148, DateTimeKind.Local).AddTicks(3912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 994, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 143, DateTimeKind.Local).AddTicks(7013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 990, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 19, 21, 46, 8, 141, DateTimeKind.Local).AddTicks(3913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 19, 21, 50, 53, 988, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80da2dbf-d84e-4e92-a507-f19bd5beb2d1", null, "Admin", null },
                    { "d73e7091-3eaa-4c5b-8faf-e982366fe18e", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "393bd9fd-e9d2-4208-9e6a-5837af7fcd42", 0, "4b20603f-4472-4a94-87d6-d2df6f56eda6", null, false, false, null, null, null, null, "123123", false, "94b8783f-b3a1-454f-9778-b2799979f92f", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "FullName", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "393bd9fd-e9d2-4208-9e6a-5837af7fcd42", "1", "Viet Nam", "", "123", "122", "1", 1 });
        }
    }
}
