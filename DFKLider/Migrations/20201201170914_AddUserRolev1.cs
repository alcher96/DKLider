using Microsoft.EntityFrameworkCore.Migrations;

namespace DFKLider.Migrations
{
    public partial class AddUserRolev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "b7c5b258-125d-4206-a748-7934db72d13f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                column: "ConcurrencyStamp",
                value: "213bf09e-5498-4828-bb53-49bd0a5aab35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88acef40-8047-4752-afd8-af58959b5753",
                column: "ConcurrencyStamp",
                value: "4e7a7ac2-1f22-4e86-b7c6-8a35df715f51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfe0cef-3152-41df-85ed-723ced351244",
                column: "ConcurrencyStamp",
                value: "b823fdbd-c08a-45cc-a774-d977e8eebe31");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a6794ee-e844-4899-8866-2df46d23c403", "AQAAAAEAACcQAAAAECOwe03Y5gxoMiHBZGNHZHOT+8TbwAfh4VuUs0//RwiBGCRyO8ue9nO0a0xXQ5C6lw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7592a35-a140-4f60-bd8c-3a38c7e440b5", "AQAAAAEAACcQAAAAELzhKGvm5Yy76pVf/p/eCn0Q0z9uVb3hZzDRQDVEY8b5lfqBDdA2NIePVuUyerOFGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b91cef19-6c7f-4bfd-9b0e-aac0bac8378c", "AQAAAAEAACcQAAAAEPl5ddm6T5djQSfYSwOfYAUY05rgwHgZiAP+cwuoux6DRqUgTY3LZ7B5KpPt1Feq1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c5a4cd7-1d3c-48ac-9efe-0b7dd16c4b2c", "AQAAAAEAACcQAAAAEGgWUPNNGFBo4u6Zu+2JdJDH3be71ehNn51k7dan8XRgurq7Mrsh6yIal/9k5tLTVQ==" });
        }
    }
}
