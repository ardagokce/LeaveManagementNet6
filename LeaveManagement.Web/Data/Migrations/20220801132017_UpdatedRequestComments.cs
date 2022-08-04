using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa1a8c8-3db2-496e-ce42-6da139a156c3",
                column: "ConcurrencyStamp",
                value: "bb85adce-b01a-4f7b-acbe-0ed73e900a8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef0b8a8-5db7-387b-cb42-9dc125d064f3",
                column: "ConcurrencyStamp",
                value: "cec7e178-48b9-4007-9bf4-9b308090b034");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ee0a8c8-4db6-496b-ba22-7bc092e055d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dea46805-3e81-44ac-a3fa-fd4032f06632", "AQAAAAEAACcQAAAAEH/zzE6qwMBmiv8oKSDeLGuoDDMdVQgaUDTLOFp3FEJ/oJioggwKwpqLkQxbibNFVA==", "892753b6-5a87-4ef8-a0a7-6038a008aa07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec2151b-add8-461c-ba74-b4e046ead07b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32aea797-0f49-43cf-bb1a-b5b14da4a8bf", "AQAAAAEAACcQAAAAEF9e1MA31poo9vJ1+LjMa2QV3QCa8Iy8Cuy77O45nvMi5QseDTRjRDnl6D8D08gnLA==", "35d3c367-9700-4cb1-a643-7d4a0b6d6652" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa1a8c8-3db2-496e-ce42-6da139a156c3",
                column: "ConcurrencyStamp",
                value: "d8978ba3-e936-4d76-9d3c-f476846c2434");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef0b8a8-5db7-387b-cb42-9dc125d064f3",
                column: "ConcurrencyStamp",
                value: "58d330b9-d58c-4d15-9966-11137a5b8bcc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ee0a8c8-4db6-496b-ba22-7bc092e055d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85db1a14-2fef-45f2-be0b-ddf8d6f5da84", "AQAAAAEAACcQAAAAEO7/U4kSoWqm8KGSFRHh9XEw9kmsDNgyuCgg5WsgGmN00Bit6dzoo9wvoTR8h67E4A==", "231364a0-9166-4c81-a492-9450356d3322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec2151b-add8-461c-ba74-b4e046ead07b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f84b5632-5071-46ed-8977-d9cc036a6cbd", "AQAAAAEAACcQAAAAEGjtdIjTAn6UMdjg6wfSjt9wnSGbPtspruaTGHTg1Yho60nTbCCwv05gpFhItBCa1w==", "7165849a-f8b5-4932-a931-bcd0657535ab" });
        }
    }
}
