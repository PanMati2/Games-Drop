using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesDrop.Data.Migrations
{
    public partial class add_carts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d228dea5-84f1-4aac-907b-b2c6632e46ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2697e8e-d09a-4c36-af2a-e77eb5e2c70d");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Carts_CardId",
                        column: x => x.CardId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b050f352-9a57-4ec6-a3d0-9d20ed37a41f", "341a792e-abcc-4f6b-a1a4-06e9b5d8a93e", "User", "User" },
                    { "9eaf5ca1-9080-4a48-bf40-520ece0c528e", "59ffe263-2edf-4a70-9f79-995f29854482", "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72B00045-7186-44C0-BDE6-568C370B7753",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8d5a2e1-bffe-4164-b450-1b1fbc53db1e", "AQAAAAEAACcQAAAAEAk9U2WNUvG3E0J3nGVFaN+VB34T917M+LzDUIDwn8LKz/Eo8h/jDkP+P6k5An+5hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BBF17FF9-151E-449B-822E-05A80274AF0E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fc87d14-ae34-4721-a4fc-494d9895b243", "AQAAAAEAACcQAAAAEEPUxVCzbAS2ZtuZj+TIn0NREvY0QIpyDtdFE4l0AtBqMSZIYPkpEJmpAs/CoO8A4w==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b050f352-9a57-4ec6-a3d0-9d20ed37a41f", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9eaf5ca1-9080-4a48-bf40-520ece0c528e", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CardId",
                table: "CartItem",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_GameId",
                table: "CartItem",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b050f352-9a57-4ec6-a3d0-9d20ed37a41f", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9eaf5ca1-9080-4a48-bf40-520ece0c528e", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eaf5ca1-9080-4a48-bf40-520ece0c528e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b050f352-9a57-4ec6-a3d0-9d20ed37a41f");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2697e8e-d09a-4c36-af2a-e77eb5e2c70d", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d228dea5-84f1-4aac-907b-b2c6632e46ed", "BBF17FF9-151E-449B-822E-05A80274AF0E" });
        }
    }
}
