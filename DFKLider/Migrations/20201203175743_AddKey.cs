using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DFKLider.Migrations
{
    public partial class AddKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Coaches_CoachId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupNumberId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GroupNumberId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Groups_CoachId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupNumberId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Coaches");

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Coaches",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "1248b2ac-4fe7-41d5-a9f4-60957f2c7785");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                column: "ConcurrencyStamp",
                value: "2d34330f-77d7-483c-9e3e-9d81d4d5478d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88acef40-8047-4752-afd8-af58959b5753",
                column: "ConcurrencyStamp",
                value: "9f3746dc-f116-4fbc-855e-477a53267842");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfe0cef-3152-41df-85ed-723ced351244",
                column: "ConcurrencyStamp",
                value: "8f5ba1a0-7102-4b29-a152-aa956c31f302");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c17550f-6c4b-418c-8837-4b10c32665f5", "AQAAAAEAACcQAAAAECJ13o69O+ZC454NOO/BRiZtyjyv6TDnr/FlTP7MzFAXPsG5ptMraT/XtOVHeANjNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e6f7e4d-7c2b-425e-8267-5732a42ce65a", "AQAAAAEAACcQAAAAEJSdvXmzs/b8ok4KcKeji43UX15zx5HbZiu6ybnVR5Sp7D+6mRFfAGtwbcs1NkQXTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb297ad2-b8d9-4773-a6e6-471ccc0e3916", "AQAAAAEAACcQAAAAEPaFj13udXnthjCohfTH2KbpRCoAkjr5MfAkUq/VV2JKK2JrE8qHol4l5yVQ1UAu3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db850c7f-fe2f-4519-a3af-c13e349e302c", "AQAAAAEAACcQAAAAEJuyMd/rIBx1ksetzIPC1xHh9ZBfnhcp44DG4dXcsf9WlcpPDom4lN/jlfyl/5YmiQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_GroupId",
                table: "Coaches",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Groups_GroupId",
                table: "Coaches",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Groups_GroupId",
                table: "Coaches");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GroupId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_GroupId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Coaches");

            migrationBuilder.AddColumn<Guid>(
                name: "GroupNumberId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CoachId",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupNumberId",
                table: "Students",
                column: "GroupNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CoachId",
                table: "Groups",
                column: "CoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Coaches_CoachId",
                table: "Groups",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupNumberId",
                table: "Students",
                column: "GroupNumberId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
