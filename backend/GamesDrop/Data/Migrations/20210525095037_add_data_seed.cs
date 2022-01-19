using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesDrop.Data.Migrations
{
    public partial class add_data_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5bae3db-a807-4557-93ea-720904d5f9d0", "f67db0f1-1d2a-41ee-a07d-b1d53c22398b", "User", "User" },
                    { "76c8ac3a-64c9-439e-b458-43d074542ffa", "e4263cb1-8f20-41cb-889f-5a3b382a61e6", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "BBF17FF9-151E-449B-822E-05A80274AF0E", 0, "1a3c0c27-eadb-4112-9136-1b15de94cecb", "admin@example.com", false, "Bill", "Gates", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFDRuWDJgnlOXlLnfV5rvT64hkWVJQcD6PlnplnhobsNzFH98DZdH0yDUeGSRT05+A==", null, false, "AE3EAA41-29C2-49BE-97EC-B5D5A38593D2", false, "admin@example.com" },
                    { "72B00045-7186-44C0-BDE6-568C370B7753", 0, "1c54c0ce-36a9-43ab-8045-2a11674eed6c", "user@example.com", false, "Will", "Smith", false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH9M089hKefWikICeZYfnfbTicJFshx6xiKRInVIsGegot5/ogDoIhzye9CC3GMxiQ==", null, false, "17BA0B4A-BDB2-44BF-ADBD-E1B66083D4D9", false, "user@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a5bae3db-a807-4557-93ea-720904d5f9d0", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76c8ac3a-64c9-439e-b458-43d074542ffa", "BBF17FF9-151E-449B-822E-05A80274AF0E" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5bae3db-a807-4557-93ea-720904d5f9d0", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76c8ac3a-64c9-439e-b458-43d074542ffa", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76c8ac3a-64c9-439e-b458-43d074542ffa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5bae3db-a807-4557-93ea-720904d5f9d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72B00045-7186-44C0-BDE6-568C370B7753");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BBF17FF9-151E-449B-822E-05A80274AF0E");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
