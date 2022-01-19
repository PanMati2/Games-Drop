using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesDrop.Data.Migrations
{
    public partial class add_devices_and_os : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_GameCategory_CategoryId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_GamePlatform_PlatformId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Key_Game_GameId",
                table: "Key");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGame_Game_GameId",
                table: "OrderGame");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGame_Key_KeyId",
                table: "OrderGame");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGame_Order_OrderId",
                table: "OrderGame");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_PaymentMethod_PaymentMethodId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Game_GameId",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderGame",
                table: "OrderGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Key",
                table: "Key");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatform",
                table: "GamePlatform");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategory",
                table: "GameCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Game",
                table: "Game");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f30d808-d49f-4a3b-b7d0-b5cb682ee5f6", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "476a1302-9ddf-444e-8d74-5442db7e172e", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "476a1302-9ddf-444e-8d74-5442db7e172e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f30d808-d49f-4a3b-b7d0-b5cb682ee5f6");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "PaymentMethod",
                newName: "PaymentMethods");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "OrderGame",
                newName: "OrderGames");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Key",
                newName: "Keys");

            migrationBuilder.RenameTable(
                name: "GamePlatform",
                newName: "GamePlatforms");

            migrationBuilder.RenameTable(
                name: "GameCategory",
                newName: "GameCategories");

            migrationBuilder.RenameTable(
                name: "Game",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_GameId",
                table: "Sales",
                newName: "IX_Sales_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payments",
                newName: "IX_Payments_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_OrderId",
                table: "Payments",
                newName: "IX_Payments_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGame_OrderId",
                table: "OrderGames",
                newName: "IX_OrderGames_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGame_KeyId",
                table: "OrderGames",
                newName: "IX_OrderGames_KeyId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGame_GameId",
                table: "OrderGames",
                newName: "IX_OrderGames_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Key_GameId",
                table: "Keys",
                newName: "IX_Keys_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Game_PlatformId",
                table: "Games",
                newName: "IX_Games_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_Game_CategoryId",
                table: "Games",
                newName: "IX_Games_CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "OperatingSystemId",
                table: "GamePlatforms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keys",
                table: "Keys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingSystems_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_OperatingSystemId",
                table: "GamePlatforms",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingSystems_DeviceId",
                table: "OperatingSystems",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatforms_OperatingSystems_OperatingSystemId",
                table: "GamePlatforms",
                column: "OperatingSystemId",
                principalTable: "OperatingSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameCategories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "GameCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GamePlatforms_PlatformId",
                table: "Games",
                column: "PlatformId",
                principalTable: "GamePlatforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Keys_Games_GameId",
                table: "Keys",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGames_Games_GameId",
                table: "OrderGames",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGames_Keys_KeyId",
                table: "OrderGames",
                column: "KeyId",
                principalTable: "Keys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGames_Orders_OrderId",
                table: "OrderGames",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentMethods_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Games_GameId",
                table: "Sales",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatforms_OperatingSystems_OperatingSystemId",
                table: "GamePlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameCategories_CategoryId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_GamePlatforms_PlatformId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Keys_Games_GameId",
                table: "Keys");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGames_Games_GameId",
                table: "OrderGames");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGames_Keys_KeyId",
                table: "OrderGames");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGames_Orders_OrderId",
                table: "OrderGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentMethods_PaymentMethodId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Games_GameId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Keys",
                table: "Keys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms");

            migrationBuilder.DropIndex(
                name: "IX_GamePlatforms_OperatingSystemId",
                table: "GamePlatforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories");

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

            migrationBuilder.DropColumn(
                name: "OperatingSystemId",
                table: "GamePlatforms");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "PaymentMethod");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderGames",
                newName: "OrderGame");

            migrationBuilder.RenameTable(
                name: "Keys",
                newName: "Key");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Game");

            migrationBuilder.RenameTable(
                name: "GamePlatforms",
                newName: "GamePlatform");

            migrationBuilder.RenameTable(
                name: "GameCategories",
                newName: "GameCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_GameId",
                table: "Sale",
                newName: "IX_Sale_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payment",
                newName: "IX_Payment_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_OrderId",
                table: "Payment",
                newName: "IX_Payment_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGames_OrderId",
                table: "OrderGame",
                newName: "IX_OrderGame_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGames_KeyId",
                table: "OrderGame",
                newName: "IX_OrderGame_KeyId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGames_GameId",
                table: "OrderGame",
                newName: "IX_OrderGame_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Keys_GameId",
                table: "Key",
                newName: "IX_Key_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_PlatformId",
                table: "Game",
                newName: "IX_Game_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CategoryId",
                table: "Game",
                newName: "IX_Game_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderGame",
                table: "OrderGame",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Key",
                table: "Key",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Game",
                table: "Game",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatform",
                table: "GamePlatform",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategory",
                table: "GameCategory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f30d808-d49f-4a3b-b7d0-b5cb682ee5f6", "6df5816e-b2c6-4357-b70d-208698896197", "User", "User" },
                    { "476a1302-9ddf-444e-8d74-5442db7e172e", "da709d8e-2fb1-4ac7-8ec4-3a1c2b858902", "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72B00045-7186-44C0-BDE6-568C370B7753",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e59d74b7-b7f6-4c09-a1cb-425acdefc3a4", "AQAAAAEAACcQAAAAEG4uIVlP5tt0aJxPq1mC06CpPapJV0aGCddYg6VadMjmOqNpvAf/toy3ba7dLBtVhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BBF17FF9-151E-449B-822E-05A80274AF0E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37e8dca7-ff67-4d01-a709-784f820fce8b", "AQAAAAEAACcQAAAAED7XxOKka+zYTh3IHv+ug+nygY5NdSXUaPCTogH/+8wrVtOgYjdnPqxKUp6GwobVoA==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8f30d808-d49f-4a3b-b7d0-b5cb682ee5f6", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "476a1302-9ddf-444e-8d74-5442db7e172e", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.AddForeignKey(
                name: "FK_Game_GameCategory_CategoryId",
                table: "Game",
                column: "CategoryId",
                principalTable: "GameCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_GamePlatform_PlatformId",
                table: "Game",
                column: "PlatformId",
                principalTable: "GamePlatform",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Key_Game_GameId",
                table: "Key",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGame_Game_GameId",
                table: "OrderGame",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGame_Key_KeyId",
                table: "OrderGame",
                column: "KeyId",
                principalTable: "Key",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGame_Order_OrderId",
                table: "OrderGame",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentMethod_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId",
                principalTable: "PaymentMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Game_GameId",
                table: "Sale",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
