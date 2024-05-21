using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OA.REPO.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_Users_UserId",
                table: "UserProfiles");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserProfiles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "AddedDate", "Address", "FirstName", "IPAddress", "LastName", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9539), "Dinajpur", "Atikul ", "192.168.3.3", "Islam", new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9555), null },
                    { 2, new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9558), "Khanasam", "Ismail ", "192.168.3.4", "Haque", new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9558), null },
                    { 3, new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9609), "Gazipur", "Mominul ", "192.168.3.5", "Islam", new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9609), null },
                    { 4, new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9611), " Dhaka", "Alamin", "192.168.3.7", " Haque", new DateTime(2024, 5, 21, 15, 55, 9, 236, DateTimeKind.Local).AddTicks(9611), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_Users_UserId",
                table: "UserProfiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_Users_UserId",
                table: "UserProfiles");

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_Users_UserId",
                table: "UserProfiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
