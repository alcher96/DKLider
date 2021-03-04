using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DFKLider.Migrations
{
    public partial class AddKeyv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Groups_GroupId",
                table: "Coaches");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_GroupId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Coaches");

            migrationBuilder.AddColumn<Guid>(
                name: "CoachId",
                table: "Groups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "35c860d6-c9ff-4396-9bbc-b56e87eadceb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                column: "ConcurrencyStamp",
                value: "5295e457-654e-44f0-a02d-1b219d671641");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88acef40-8047-4752-afd8-af58959b5753",
                column: "ConcurrencyStamp",
                value: "82b5f2dc-9223-46f9-befb-45686a16e1e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfe0cef-3152-41df-85ed-723ced351244",
                column: "ConcurrencyStamp",
                value: "52bea179-f3d2-4f02-9bf5-8a4d889ebe83");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ceb1d2e-93be-41d6-aae5-5352bf01b735", "AQAAAAEAACcQAAAAEEbiz/eUGfg4/9Ls2DW2USGcCSZW6MYRCYhYqFYrLYQ0+M8OaiykH64y0e8j144zDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74471614-8dd2-44bb-a040-706f5bfcb9ac", "AQAAAAEAACcQAAAAEDkc1RpaLtzvF+kNiTMyqNbqis+z/QUOZCWnIBVXwF3qqCkWU6I+Ej3iTNJOf8t32A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d30ce3b7-dbd4-42bb-b3bd-e28c0875055c", "AQAAAAEAACcQAAAAEG0pcn8rnmAwRrYL2bEkc/OULOIE52DAbt8/XGF8AH14sJQu9OeKk4s3wC0s4Sb9lw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6c2ce0d-b967-49e0-8f1b-c01236b612a5", "AQAAAAEAACcQAAAAECuyo1VIxTRvwMK9M7e+cZugueqYhhbDyKvVeL3zr24CYK7gzNVPp0mjzR6d3uQOHw==" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Coaches_CoachId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_CoachId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Groups");

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "Coaches",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c093d319-57dd-4a0c-8ba5-1403605f3122");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                column: "ConcurrencyStamp",
                value: "a1694f21-c444-490a-a1ff-2055ab8e7ee3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88acef40-8047-4752-afd8-af58959b5753",
                column: "ConcurrencyStamp",
                value: "e0242c58-ab1e-4f72-a67b-a017a0c26e47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfe0cef-3152-41df-85ed-723ced351244",
                column: "ConcurrencyStamp",
                value: "11014386-5d5c-4861-8961-601da9f85262");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e86d1be-2207-4dcf-b7ad-1856cf3ff7b6", "AQAAAAEAACcQAAAAEEVQxMSf1XbC31VOnqSA7AzC0jLxCuHq6xcojnSvFuAygc9AdhwnGfWVTauCJwtfaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25720911-9586-4e52-b75f-c8f941ba7765", "AQAAAAEAACcQAAAAEIrN3jQS20i+xX2VeuPDrmBQ7WK8TVdsqPBZfhMCKJHm+6c3B05IXVj5Qh4NyBozqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b4ec3ab-5946-4dda-bc2c-68cc8ad26e85", "AQAAAAEAACcQAAAAEG5xSGLXUHYe0Y85QDrWQindntBPVW52RjwGtTzPg+EdPk3EjqizQszlh8mWAAZ94A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "542c5aa3-62e9-422d-a361-66ef0f6f30d9", "AQAAAAEAACcQAAAAEG1Di3nJj5e5tU8w52YNUiuKrFZXdN2704gP5SxFtABqhdzlRkrt8kfsrx3/fa1SSA==" });

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
        }
    }
}
