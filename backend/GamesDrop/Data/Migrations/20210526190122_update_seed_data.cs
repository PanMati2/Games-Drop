using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesDrop.Data.Migrations
{
    public partial class update_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d8ce226-c482-4be1-ae67-e0cb5e2036ca", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0051db4-dff1-4a02-91e9-e280017163a8", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d8ce226-c482-4be1-ae67-e0cb5e2036ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0051db4-dff1-4a02-91e9-e280017163a8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e2697e8e-d09a-4c36-af2a-e77eb5e2c70d", "03e77333-d906-4b2e-9f18-7dd8fa6ca47d", "User", "User" },
                    { "d228dea5-84f1-4aac-907b-b2c6632e46ed", "4dee2f48-ff20-4a64-bba9-91318da16b72", "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72B00045-7186-44C0-BDE6-568C370B7753",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "324779a7-75a8-46e1-80ae-a6b18f226b55", "AQAAAAEAACcQAAAAEC8N6ITQ8Evf5LcPa/uzXQcOHSBG1zt155pGWdc6+9ffZYLLw0dBLjhwINAioSsvJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BBF17FF9-151E-449B-822E-05A80274AF0E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a9a2e05-bcbd-4eed-b1df-2f9f8625c3b9", "AQAAAAEAACcQAAAAEOceCW7ww9VUDYdYonGtsccosuhPxrWkax2MF7GtLACchpvPalGYiQTVQXudvGS4eg==" });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "Name", "OperatingSystemId" },
                values: new object[] { 8, "Nintendo", 6 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2697e8e-d09a-4c36-af2a-e77eb5e2c70d", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d228dea5-84f1-4aac-907b-b2c6632e46ed", "BBF17FF9-151E-449B-822E-05A80274AF0E" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2697e8e-d09a-4c36-af2a-e77eb5e2c70d", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d228dea5-84f1-4aac-907b-b2c6632e46ed", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d228dea5-84f1-4aac-907b-b2c6632e46ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2697e8e-d09a-4c36-af2a-e77eb5e2c70d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d8ce226-c482-4be1-ae67-e0cb5e2036ca", "0c1f417c-5d6d-42f5-af3c-de292ea4963b", "User", "User" },
                    { "a0051db4-dff1-4a02-91e9-e280017163a8", "0ac8763b-a7c9-4cef-8bb7-6c799b7b90bc", "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72B00045-7186-44C0-BDE6-568C370B7753",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45dcce83-dfc7-40b4-8885-56d400e61dfe", "AQAAAAEAACcQAAAAEJOjgnjOt7uR/Ln1o5LcjQGCGbI7y1MwHmZo6RNJ/lMT01OMMvegaX+0a5bxxYr/QA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BBF17FF9-151E-449B-822E-05A80274AF0E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b70bb3d6-01a6-4beb-a83e-76c0c217746b", "AQAAAAEAACcQAAAAEFlPxNS9CgO29OqJ/3ISu2mfr8IB8DXZmvWdh0l3rXT6cFA/4nHzZUPaMBCkUvMo0w==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1d8ce226-c482-4be1-ae67-e0cb5e2036ca", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a0051db4-dff1-4a02-91e9-e280017163a8", "BBF17FF9-151E-449B-822E-05A80274AF0E" });
        }
    }
}
