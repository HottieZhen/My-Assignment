using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderingWebsite.Web.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 248, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "FoodMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 248, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "FoodMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 248, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 248, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 249, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 249, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 241, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 244, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 244, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 10, 36, 7, 244, DateTimeKind.Local).AddTicks(9090));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 940, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "FoodMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 940, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "FoodMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 940, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 940, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 940, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 940, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 910, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 934, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 934, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 6, 25, 2, 9, 41, 934, DateTimeKind.Local).AddTicks(6560));
        }
    }
}
