using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DFKLider.Migrations
{
    public partial class AddUserRolev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Coaches",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AdminRole = table.Column<string>(nullable: true),
                    StudentRole = table.Column<string>(nullable: true),
                    ParentRole = table.Column<string>(nullable: true),
                    CoachRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "422c4ceb-0fba-47c4-9b37-23a2e1c6fc2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                column: "ConcurrencyStamp",
                value: "89b4ddc9-53f4-4404-8416-f86f0a589a9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88acef40-8047-4752-afd8-af58959b5753",
                column: "ConcurrencyStamp",
                value: "47e210be-9c22-4535-bcaa-9f848a602adc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfe0cef-3152-41df-85ed-723ced351244",
                column: "ConcurrencyStamp",
                value: "3aa22f43-73cc-48cd-8e81-f214b8244bd6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5c0452d-6f6a-4355-ad8f-a4e16066fcc7", "AQAAAAEAACcQAAAAEDCVemcBUd83F4SEyWswV4CIcfB1bBjAcDIdwFjktI6vHwqvCU4UF6cAH5b67Bge6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "793dd29e-2e19-45bf-9d21-c3e3c1bb463d", "AQAAAAEAACcQAAAAECMARdNWXGxBo5cDfzuTWbu8xFeOb5bTDChUeR36KqLBjlXJ/wPjDh83FqP0yNhhPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7e6a654-519c-43b5-962c-5f2005a13e9a", "AQAAAAEAACcQAAAAEGHPvzo+zC6BMk0Y1OCzqNzdAtmRoCRcZoJyCSIfCPnflzHr6KV2DSy2JFygRmTeJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1c36613-2ce7-4913-879f-28ab050d78dc", "AQAAAAEAACcQAAAAEBPPMYwbeZ2tkNwq1AirEf/AlHfJURF+Ccz4xABL2u/FpC9P5xO4pmAoMDU2nQIdSw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Coaches");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "943bacfc-38b9-42a7-a4ee-b539876713fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                column: "ConcurrencyStamp",
                value: "d83829c2-a566-472f-b268-0beb63fe1d92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88acef40-8047-4752-afd8-af58959b5753",
                column: "ConcurrencyStamp",
                value: "a9cce699-e0ad-4a5a-b8d0-ee837fcc4490");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfe0cef-3152-41df-85ed-723ced351244",
                column: "ConcurrencyStamp",
                value: "04a03dbc-924b-48e1-b9f7-0186684b657f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6b036a2-1286-4c5c-8f44-660959ee0f45", "AQAAAAEAACcQAAAAENqae/Wuq4T8Fv/1Vv7Gr4v0usacM/vumYrHF2cPGAsgjeXxSFX1+3l5or/QuC9Q6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cb46cdc-9de5-4012-9e78-03b48122b031", "AQAAAAEAACcQAAAAECup7D+CAlp8iqsMxsar5BqIeje40DvePuxAKw4vXgT+zvPrQnlpJgP9r1cw8NB6Xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "694ff375-4715-4dd1-9a2c-e2ccdaface2a", "AQAAAAEAACcQAAAAEG1vjyEhQ5LblTEAb2h48FFW6rgEUHSUgyOW8RXQGT/Pyw/zMvb4let/IGq9WoAKAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d78247bc-6f0d-4dd6-b409-c6acc8b35a67", "AQAAAAEAACcQAAAAEOFDU9FIsjEt3ZFue+Jt+tmsCTHWNocvwoDnqqt4o7nUBCUpcAuyPcUmyZkACrtcYw==" });
        }
    }
}
