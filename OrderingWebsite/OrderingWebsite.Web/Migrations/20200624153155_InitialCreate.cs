using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderingWebsite.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    StockCount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    ImgUrl = table.Column<string>(maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order_Food",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(nullable: false),
                    FoodId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    NickName = table.Column<string>(maxLength: 500, nullable: true),
                    Avatar = table.Column<string>(maxLength: 500, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Phone = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "荤菜" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "素菜" });

            migrationBuilder.InsertData(
                table: "FoodMenu",
                columns: new[] { "Id", "CreateTime", "Description", "ImgUrl", "Name", "Price", "StockCount", "Type" },
                values: new object[] { 1, new DateTime(2020, 6, 24, 23, 31, 54, 937, DateTimeKind.Local).AddTicks(6720), "好吃的油焖大虾，2斤一份", "/upload/youmendaxie.jpg", "油焖大虾", 128m, 100, "荤菜" });

            migrationBuilder.InsertData(
                table: "FoodMenu",
                columns: new[] { "Id", "CreateTime", "Description", "ImgUrl", "Name", "Price", "StockCount", "Type" },
                values: new object[] { 2, new DateTime(2020, 6, 24, 23, 31, 54, 937, DateTimeKind.Local).AddTicks(8030), "手撕包菜", "/upload/1.jpg", "手撕包菜", 12m, 100, "荤菜" });

            migrationBuilder.InsertData(
                table: "FoodMenu",
                columns: new[] { "Id", "CreateTime", "Description", "ImgUrl", "Name", "Price", "StockCount", "Type" },
                values: new object[] { 3, new DateTime(2020, 6, 24, 23, 31, 54, 937, DateTimeKind.Local).AddTicks(8070), "水煮肉片一份", "/upload/shuizutoupian.jpg", "水煮肉片", 38m, 100, "荤菜" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CreateTime", "LastUpdatedTime", "Price", "Status", "UserId" },
                values: new object[] { 1, new DateTime(2020, 6, 24, 23, 31, 54, 938, DateTimeKind.Local).AddTicks(1000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, "已付款", 1 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CreateTime", "LastUpdatedTime", "Price", "Status", "UserId" },
                values: new object[] { 2, new DateTime(2020, 6, 24, 23, 31, 54, 938, DateTimeKind.Local).AddTicks(2290), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, "已送货", 3 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CreateTime", "LastUpdatedTime", "Price", "Status", "UserId" },
                values: new object[] { 3, new DateTime(2020, 6, 24, 23, 31, 54, 938, DateTimeKind.Local).AddTicks(2340), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, "已完成", 3 });

            migrationBuilder.InsertData(
                table: "Order_Food",
                columns: new[] { "Id", "Count", "FoodId", "OrderId" },
                values: new object[] { 1, 0, 1, 1 });

            migrationBuilder.InsertData(
                table: "Order_Food",
                columns: new[] { "Id", "Count", "FoodId", "OrderId" },
                values: new object[] { 2, 0, 2, 1 });

            migrationBuilder.InsertData(
                table: "Order_Food",
                columns: new[] { "Id", "Count", "FoodId", "OrderId" },
                values: new object[] { 3, 0, 2, 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Avatar", "CreateTime", "Name", "NickName", "Password", "Phone", "RoleId" },
                values: new object[] { 1, "慈溪市科院3#443", null, new DateTime(2020, 6, 24, 23, 31, 54, 910, DateTimeKind.Local).AddTicks(4550), "吴皇震", "HZW", "123", "13568955684", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Avatar", "CreateTime", "Name", "NickName", "Password", "Phone", "RoleId" },
                values: new object[] { 2, "慈溪市科院3#443", null, new DateTime(2020, 6, 24, 23, 31, 54, 929, DateTimeKind.Local).AddTicks(5780), "方浩亦", "FHY", "123", "13668955684", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Avatar", "CreateTime", "Name", "NickName", "Password", "Phone", "RoleId" },
                values: new object[] { 3, "慈溪市科院3#443", null, new DateTime(2020, 6, 24, 23, 31, 54, 929, DateTimeKind.Local).AddTicks(5820), "张淼", "SSSSSS", "13668955684", "13668234244", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Avatar", "CreateTime", "Name", "NickName", "Password", "Phone", "RoleId" },
                values: new object[] { 4, "慈溪市科院3#443", null, new DateTime(2020, 6, 24, 23, 31, 54, 929, DateTimeKind.Local).AddTicks(5830), "Admin", "HZW", "123", "13568955684", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "FoodMenu");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Order_Food");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
