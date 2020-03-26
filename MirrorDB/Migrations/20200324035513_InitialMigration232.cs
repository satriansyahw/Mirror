using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MirrorDB.Migrations
{
    public partial class InitialMigration232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 55, 13, 174, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 803, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbo",
                table: "MTEmp",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 55, 13, 175, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbo",
                table: "DTCovid",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 55, 13, 175, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 803, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 55, 13, 174, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbo",
                table: "MTEmp",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 55, 13, 175, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbo",
                table: "DTCovid",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 55, 13, 175, DateTimeKind.Local));
        }
    }
}
