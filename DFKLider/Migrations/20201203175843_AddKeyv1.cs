using Microsoft.EntityFrameworkCore.Migrations;

namespace DFKLider.Migrations
{
    public partial class AddKeyv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
