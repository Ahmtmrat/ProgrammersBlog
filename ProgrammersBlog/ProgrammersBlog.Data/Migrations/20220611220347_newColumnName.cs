using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class newColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 378, DateTimeKind.Local).AddTicks(6742), new DateTime(2022, 6, 12, 1, 3, 47, 378, DateTimeKind.Local).AddTicks(6194), new DateTime(2022, 6, 12, 1, 3, 47, 378, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 378, DateTimeKind.Local).AddTicks(7634), new DateTime(2022, 6, 12, 1, 3, 47, 378, DateTimeKind.Local).AddTicks(7632), new DateTime(2022, 6, 12, 1, 3, 47, 378, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7699), new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7716), new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7724), new DateTime(2022, 6, 12, 1, 3, 47, 380, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 382, DateTimeKind.Local).AddTicks(1621), new DateTime(2022, 6, 12, 1, 3, 47, 382, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 382, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 6, 12, 1, 3, 47, 382, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 383, DateTimeKind.Local).AddTicks(2387), new DateTime(2022, 6, 12, 1, 3, 47, 383, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 1, 3, 47, 391, DateTimeKind.Local).AddTicks(3289), new DateTime(2022, 6, 12, 1, 3, 47, 391, DateTimeKind.Local).AddTicks(3298) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 657, DateTimeKind.Local).AddTicks(2619), new DateTime(2022, 5, 29, 16, 27, 18, 657, DateTimeKind.Local).AddTicks(1972), new DateTime(2022, 5, 29, 16, 27, 18, 657, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 657, DateTimeKind.Local).AddTicks(3688), new DateTime(2022, 5, 29, 16, 27, 18, 657, DateTimeKind.Local).AddTicks(3686), new DateTime(2022, 5, 29, 16, 27, 18, 657, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6174), new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6195), new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6200), new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6205), new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 661, DateTimeKind.Local).AddTicks(1366), new DateTime(2022, 5, 29, 16, 27, 18, 661, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 661, DateTimeKind.Local).AddTicks(1385), new DateTime(2022, 5, 29, 16, 27, 18, 661, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 662, DateTimeKind.Local).AddTicks(4031), new DateTime(2022, 5, 29, 16, 27, 18, 662, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 27, 18, 672, DateTimeKind.Local).AddTicks(2223), new DateTime(2022, 5, 29, 16, 27, 18, 672, DateTimeKind.Local).AddTicks(2233) });
        }
    }
}
