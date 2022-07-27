using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa1a8c8-3db2-496e-ce42-6da139a156c3",
                column: "ConcurrencyStamp",
                value: "f22bcd1c-e46b-4207-a38f-a77053083ea9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef0b8a8-5db7-387b-cb42-9dc125d064f3",
                column: "ConcurrencyStamp",
                value: "f6739baa-207e-472f-86fa-1aeb1658e33e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ee0a8c8-4db6-496b-ba22-7bc092e055d3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e139013f-bb73-4889-9b0e-72c0acd142f0", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEH3W95njtU72Se5B6WRHOpBpx7Q2tFbtKRt8fdexute9QXKuS+VoD5G4UoLXct90WA==", "7b4dc4b8-0985-4524-b6ce-4a058578dca2", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec2151b-add8-461c-ba74-b4e046ead07b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5bc6faa3-dddf-4b52-8725-7fcde6be87f3", true, "ARDA@TEST.COM", "AQAAAAEAACcQAAAAEJkg54NK4x7WLmUt+jc4XA14zT9nGvP51udn8gBHyaLRJtVyx9nx3vwUMYGxEspOOg==", "869a0d96-c963-4214-a639-595605c21c19", "arda@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa1a8c8-3db2-496e-ce42-6da139a156c3",
                column: "ConcurrencyStamp",
                value: "33a46697-1d68-4ebc-af74-b2113993e4db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef0b8a8-5db7-387b-cb42-9dc125d064f3",
                column: "ConcurrencyStamp",
                value: "069d97d0-d9de-4e47-97b3-03accd8b85f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ee0a8c8-4db6-496b-ba22-7bc092e055d3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cf6d0426-f03f-4762-adfa-5b6155236f09", false, null, "AQAAAAEAACcQAAAAEOe6zW7shnVyCukr4ObgSOgAqdPuPXieNkbVjaiMqDgd3AYpb7Q9OhYax/qpuJR+NQ==", "a4157821-9d65-4c1d-85ff-3f6be2fbd2fa", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec2151b-add8-461c-ba74-b4e046ead07b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2b91727d-dd6a-4316-95c4-574d12805ed4", false, null, "AQAAAAEAACcQAAAAEG6RDWYKXTIiLg/4DYej9RUbFVBMV9ckPiz/gptccXKM1A8LI/0QUtWp/cnYiRGv9Q==", "bb645d75-4607-43cd-b32f-d381eb81ee24", null });
        }
    }
}
