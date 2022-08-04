using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
