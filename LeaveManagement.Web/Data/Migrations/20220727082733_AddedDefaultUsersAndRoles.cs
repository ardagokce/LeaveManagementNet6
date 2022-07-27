using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8fa1a8c8-3db2-496e-ce42-6da139a156c3", "33a46697-1d68-4ebc-af74-b2113993e4db", "User", "USER" },
                    { "9ef0b8a8-5db7-387b-cb42-9dc125d064f3", "069d97d0-d9de-4e47-97b3-03accd8b85f9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8ee0a8c8-4db6-496b-ba22-7bc092e055d3", 0, "cf6d0426-f03f-4762-adfa-5b6155236f09", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEOe6zW7shnVyCukr4ObgSOgAqdPuPXieNkbVjaiMqDgd3AYpb7Q9OhYax/qpuJR+NQ==", null, false, "a4157821-9d65-4c1d-85ff-3f6be2fbd2fa", null, false, null },
                    { "dec2151b-add8-461c-ba74-b4e046ead07b", 0, "2b91727d-dd6a-4316-95c4-574d12805ed4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arda@test.com", false, "Arda", "Gokce", false, null, "ARDA@TEST.COM", null, "AQAAAAEAACcQAAAAEG6RDWYKXTIiLg/4DYej9RUbFVBMV9ckPiz/gptccXKM1A8LI/0QUtWp/cnYiRGv9Q==", null, false, "bb645d75-4607-43cd-b32f-d381eb81ee24", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ef0b8a8-5db7-387b-cb42-9dc125d064f3", "8ee0a8c8-4db6-496b-ba22-7bc092e055d3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8fa1a8c8-3db2-496e-ce42-6da139a156c3", "dec2151b-add8-461c-ba74-b4e046ead07b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ef0b8a8-5db7-387b-cb42-9dc125d064f3", "8ee0a8c8-4db6-496b-ba22-7bc092e055d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8fa1a8c8-3db2-496e-ce42-6da139a156c3", "dec2151b-add8-461c-ba74-b4e046ead07b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa1a8c8-3db2-496e-ce42-6da139a156c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef0b8a8-5db7-387b-cb42-9dc125d064f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ee0a8c8-4db6-496b-ba22-7bc092e055d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec2151b-add8-461c-ba74-b4e046ead07b");
        }
    }
}
