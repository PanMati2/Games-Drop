using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesDrop.Data.Migrations
{
    public partial class add_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd93c06c-40b6-46ef-97d7-fa1d20f3836b", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b6c5d2d-855c-4f76-9a88-44a2082a2915", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b6c5d2d-855c-4f76-9a88-44a2082a2915");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd93c06c-40b6-46ef-97d7-fa1d20f3836b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a0051db4-dff1-4a02-91e9-e280017163a8", "0ac8763b-a7c9-4cef-8bb7-6c799b7b90bc", "Admin", "Admin" },
                    { "1d8ce226-c482-4be1-ae67-e0cb5e2036ca", "0c1f417c-5d6d-42f5-af3c-de292ea4963b", "User", "User" }
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
                table: "Devices",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 4, "Nintendo" },
                    { 3, "Xbox" },
                    { 2, "Playstation" }
                });

            migrationBuilder.InsertData(
                table: "GameCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Przygodowa" },
                    { 3, "Jednoosobowa" },
                    { 4, "Indie" },
                    { 5, "Strategiczna" },
                    { 7, "Wieloosobowa" },
                    { 8, "RPG" },
                    { 9, "Casual" },
                    { 1, "Akcji" },
                    { 6, "Symulacja" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Przelew tradycyjny" },
                    { 2, "BLIK" },
                    { 3, "przelewy24" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1d8ce226-c482-4be1-ae67-e0cb5e2036ca", "72B00045-7186-44C0-BDE6-568C370B7753" },
                    { "a0051db4-dff1-4a02-91e9-e280017163a8", "BBF17FF9-151E-449B-822E-05A80274AF0E" }
                });

            migrationBuilder.InsertData(
                table: "OperatingSystems",
                columns: new[] { "Id", "DeviceId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Windows 10" },
                    { 2, 2, "PS4" },
                    { 3, 2, "PS5" },
                    { 4, 3, "One" },
                    { 5, 3, "Series" },
                    { 6, 4, "Switch" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "Name", "OperatingSystemId" },
                values: new object[,]
                {
                    { 1, "Steam", 1 },
                    { 2, "Epic Games", 1 },
                    { 3, "Origin", 1 },
                    { 4, "Playstation network", 2 },
                    { 5, "Playstation network", 3 },
                    { 6, "Xbox live", 4 },
                    { 7, "Xbox live", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d8ce226-c482-4be1-ae67-e0cb5e2036ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0051db4-dff1-4a02-91e9-e280017163a8");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd93c06c-40b6-46ef-97d7-fa1d20f3836b", "edbf3af3-4d8c-48b3-adc2-dd56d2f82e74", "User", "User" },
                    { "1b6c5d2d-855c-4f76-9a88-44a2082a2915", "8d80ec0f-7d8c-4a10-867c-459e3f56c7d8", "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72B00045-7186-44C0-BDE6-568C370B7753",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7d1112e-e8a4-4c90-932d-c49e1528e0c7", "AQAAAAEAACcQAAAAEGIIqidHux8rNTelghUEcpzaEXDGqCTKkz/J95d2l5GmonWZiJPbaJvUmdR21qKopw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BBF17FF9-151E-449B-822E-05A80274AF0E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd5fd17c-4d62-4dce-bf2a-8cca5aad5a92", "AQAAAAEAACcQAAAAEMF1/bVFR+WbZ25X+WurnpA9GsW42St+SBaa46vm+FftqPOJ0L5rL7K4Z+B1gem7gQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dd93c06c-40b6-46ef-97d7-fa1d20f3836b", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1b6c5d2d-855c-4f76-9a88-44a2082a2915", "BBF17FF9-151E-449B-822E-05A80274AF0E" });
        }
    }
}
