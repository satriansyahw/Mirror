using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MirrorDB.Migrations
{
    public partial class InitialMigration23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "MTEmp",
                schema: "dbMob",
                newName: "MTEmp",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "DTCovid",
                schema: "dbMob",
                newName: "DTCovid",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 803, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 973, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbo",
                table: "MTEmp",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbo",
                table: "DTCovid",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbMob");

            migrationBuilder.RenameTable(
                name: "MTEmp",
                schema: "dbo",
                newName: "MTEmp",
                newSchema: "dbMob");

            migrationBuilder.RenameTable(
                name: "DTCovid",
                schema: "dbo",
                newName: "DTCovid",
                newSchema: "dbMob");

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 973, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 803, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbMob",
                table: "MTEmp",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbMob",
                table: "DTCovid",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 10, 53, 27, 804, DateTimeKind.Local));
        }
    }
}
