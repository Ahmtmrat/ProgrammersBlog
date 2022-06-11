using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 4, "InitialCreate", new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6205), "JS-React programlama dili ile ilgili en güncel bilgiler", true, false, "InitialCreate", new DateTime(2022, 5, 29, 16, 27, 18, 659, DateTimeKind.Local).AddTicks(6206), "JS-React", "JS-React Blog Kategorisi" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 419, DateTimeKind.Local).AddTicks(2543), new DateTime(2022, 5, 29, 16, 22, 44, 419, DateTimeKind.Local).AddTicks(1793), new DateTime(2022, 5, 29, 16, 22, 44, 419, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 419, DateTimeKind.Local).AddTicks(3591), new DateTime(2022, 5, 29, 16, 22, 44, 419, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 5, 29, 16, 22, 44, 419, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 421, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 5, 29, 16, 22, 44, 421, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 421, DateTimeKind.Local).AddTicks(4966), new DateTime(2022, 5, 29, 16, 22, 44, 421, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 421, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 5, 29, 16, 22, 44, 421, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 422, DateTimeKind.Local).AddTicks(9698), new DateTime(2022, 5, 29, 16, 22, 44, 422, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 422, DateTimeKind.Local).AddTicks(9717), new DateTime(2022, 5, 29, 16, 22, 44, 422, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 424, DateTimeKind.Local).AddTicks(2498), new DateTime(2022, 5, 29, 16, 22, 44, 424, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 22, 44, 434, DateTimeKind.Local).AddTicks(526), new DateTime(2022, 5, 29, 16, 22, 44, 434, DateTimeKind.Local).AddTicks(540) });
        }
    }
}
