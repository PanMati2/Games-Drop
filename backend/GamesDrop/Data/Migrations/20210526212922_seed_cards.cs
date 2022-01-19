using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesDrop.Data.Migrations
{
    public partial class seed_cards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "ddff8859-63af-4353-9ebc-a0f76014b93e", "6e4ce9a3-5194-4809-9c12-6f9ab5fcb1ea", "User", "User" },
                    { "bf74082f-8008-470d-92a3-41b56ac3e204", "443cb481-c2ad-446b-9f82-de44f29f1fd5", "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72B00045-7186-44C0-BDE6-568C370B7753",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13cdd86d-f061-48a9-8950-7eb4433ceb63", "AQAAAAEAACcQAAAAECszLmEIgBc/ahcw3xmJxSUOySb75sWanxySSiOtjh/nqs67Ie0ZYjK++00DalQQNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BBF17FF9-151E-449B-822E-05A80274AF0E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d93700a-d264-48d7-bf70-252a94c4e784", "AQAAAAEAACcQAAAAELAxQQWWzuHE7bV1ea+lEQzXmdpMX31XSlg+nwNpIkebGtlrhi++5MfXq3c1WO0i7A==" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "BBF17FF9-151E-449B-822E-05A80274AF0E" },
                    { 2, "72B00045-7186-44C0-BDE6-568C370B7753" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ddff8859-63af-4353-9ebc-a0f76014b93e", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf74082f-8008-470d-92a3-41b56ac3e204", "BBF17FF9-151E-449B-822E-05A80274AF0E" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddff8859-63af-4353-9ebc-a0f76014b93e", "72B00045-7186-44C0-BDE6-568C370B7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf74082f-8008-470d-92a3-41b56ac3e204", "BBF17FF9-151E-449B-822E-05A80274AF0E" });

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf74082f-8008-470d-92a3-41b56ac3e204");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddff8859-63af-4353-9ebc-a0f76014b93e");

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
        }
    }
}
