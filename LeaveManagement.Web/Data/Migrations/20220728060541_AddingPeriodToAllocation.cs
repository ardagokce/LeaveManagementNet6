using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa1a8c8-3db2-496e-ce42-6da139a156c3",
                column: "ConcurrencyStamp",
                value: "2cbf2fee-226e-4ca6-ad90-7915a4c3a2d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef0b8a8-5db7-387b-cb42-9dc125d064f3",
                column: "ConcurrencyStamp",
                value: "b6b01dc1-5ad6-43bf-86d1-19255e76e618");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ee0a8c8-4db6-496b-ba22-7bc092e055d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "486d573d-5381-4b01-9e47-011e117c3cc1", "AQAAAAEAACcQAAAAEEHtZGcO7zqDA7YQOOiB43J83TMulcaMWSeaIDppGz4sR56TJS6h5w3Y0JRxqtBC5w==", "b4da8e99-cdca-46e4-b9b4-5d22d6b70beb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec2151b-add8-461c-ba74-b4e046ead07b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e977b525-c1d9-42f2-8419-725956206058", "AQAAAAEAACcQAAAAENE/ahDb4J2Cn/dYZ+MIZmTFTMRVXwWBN23J08mBCy4Emo9/4iJ8KI8AC78DwgYoxQ==", "32d70d94-cfae-494d-a9dd-2dc1858a00da" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e139013f-bb73-4889-9b0e-72c0acd142f0", "AQAAAAEAACcQAAAAEH3W95njtU72Se5B6WRHOpBpx7Q2tFbtKRt8fdexute9QXKuS+VoD5G4UoLXct90WA==", "7b4dc4b8-0985-4524-b6ce-4a058578dca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec2151b-add8-461c-ba74-b4e046ead07b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bc6faa3-dddf-4b52-8725-7fcde6be87f3", "AQAAAAEAACcQAAAAEJkg54NK4x7WLmUt+jc4XA14zT9nGvP51udn8gBHyaLRJtVyx9nx3vwUMYGxEspOOg==", "869a0d96-c963-4214-a639-595605c21c19" });
        }
    }
}
