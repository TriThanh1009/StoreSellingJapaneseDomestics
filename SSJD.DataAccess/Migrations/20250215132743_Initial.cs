using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SSJD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79874087-7a28-41e1-b641-fea91d980384");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd392ff7-12f9-49d9-98f1-006fa8816c50");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "95476330-d900-43f4-8dc2-abf57a33d82e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95476330-d900-43f4-8dc2-abf57a33d82e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 529, DateTimeKind.Local).AddTicks(2867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 186, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 529, DateTimeKind.Local).AddTicks(2699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 186, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 529, DateTimeKind.Local).AddTicks(425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 185, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 525, DateTimeKind.Local).AddTicks(3774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 183, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 523, DateTimeKind.Local).AddTicks(3545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 181, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9162d741-f522-446b-9021-20d9b1c4d70e", null, "Admin", "ADMIN" },
                    { "dfd56e6a-5a46-4748-a6e3-50e2b71895ad", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03f41669-f2b4-4bb0-a0ea-d36a53f52872", "00c15649-0605-4dd6-b345-768870207f71" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a13003ba-b33e-455b-9bd7-80996bc2d92c", 0, "27385588-fa04-4e79-ae66-84acdbd788cc", null, false, false, null, null, null, null, "123123", false, "633a6ebd-ebf2-4a80-8e2a-092df7b753a0", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "a13003ba-b33e-455b-9bd7-80996bc2d92c", "1", "Viet Nam", "123", "122", "1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9162d741-f522-446b-9021-20d9b1c4d70e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd56e6a-5a46-4748-a6e3-50e2b71895ad");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a13003ba-b33e-455b-9bd7-80996bc2d92c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a13003ba-b33e-455b-9bd7-80996bc2d92c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 186, DateTimeKind.Local).AddTicks(1784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 529, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 186, DateTimeKind.Local).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 529, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Warranty",
                table: "ProductDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 185, DateTimeKind.Local).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 529, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 183, DateTimeKind.Local).AddTicks(293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 525, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 20, 27, 39, 181, DateTimeKind.Local).AddTicks(2935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 20, 27, 43, 523, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79874087-7a28-41e1-b641-fea91d980384", null, "Customer", "CUSTOMER" },
                    { "cd392ff7-12f9-49d9-98f1-006fa8816c50", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e50a6a37-59c7-4043-a8fb-ef3b703aaf42", "c193dcdd-1959-4fe5-92f7-753766d53efb" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "95476330-d900-43f4-8dc2-abf57a33d82e", 0, "a0998e42-ea89-4e06-8f66-8a7582a98af5", null, false, false, null, null, null, null, "123123", false, "976f25b8-09fd-4153-abba-c569e276b9f8", false, "Nguyen Tri Thanh" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountID", "Address", "IdentityCard", "Image", "MemberCardID", "Sex" },
                values: new object[] { "95476330-d900-43f4-8dc2-abf57a33d82e", "1", "Viet Nam", "123", "122", "1", 1 });
        }
    }
}
