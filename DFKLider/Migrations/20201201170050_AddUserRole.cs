using Microsoft.EntityFrameworkCore.Migrations;

namespace DFKLider.Migrations
{
    public partial class AddUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "004180a2-bcf2-49c8-be47-86410b9c0730");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                column: "ConcurrencyStamp",
                value: "2ac6b0b2-af8c-4224-ace5-22e41606c89f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88acef40-8047-4752-afd8-af58959b5753",
                column: "ConcurrencyStamp",
                value: "c3572617-5ba2-4a9f-9b5c-bb6c4bf8148f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfe0cef-3152-41df-85ed-723ced351244",
                column: "ConcurrencyStamp",
                value: "9f0c2981-1ce7-4c7b-9f76-faaa40458f39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba5dd34b-74ce-4e28-a96c-67062b8f8ca8", "AQAAAAEAACcQAAAAELOOPbwc+Op367YO1U3PdT+6gcYpfen+zwLf3/c42YJtXkMPoETMp0Nxwn9lkxw9TA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99ad13c1-1fad-49a8-ae37-89c134bf95b3", "AQAAAAEAACcQAAAAEA48qdzEMLItPEJU+1DV+rxw1wsZtUGwZeYCA7+GdAtc/OI8fjfb5C3AKBnGbmpnEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9332404d-8a4e-4e68-8115-b8edbe8be47c", "AQAAAAEAACcQAAAAED+SB1JTZ3+i1FUqLEQjYgMDrZwF/LlEpSsHj8BVJlo7UE2pNAXeZ9gdck6XWt8FcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35d94cac-4b92-433a-bd80-70eb4b015f95", "AQAAAAEAACcQAAAAEPahjsAWcn+geHulcvtCx0IQ8rZ17lkAZ6wpnmIwMXxMeodxLs1WpiPfbLPHwJ26FQ==" });
        }
    }
}
