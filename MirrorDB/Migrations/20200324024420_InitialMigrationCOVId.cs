using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MirrorDB.Migrations
{
    public partial class InitialMigrationCOVId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FakeTable_UserName2",
                schema: "fake",
                table: "FakeTable");

            migrationBuilder.EnsureSchema(
                name: "dbMob");

            migrationBuilder.AlterColumn<string>(
                name: "UserName2",
                schema: "fake",
                table: "FakeTable",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "fake",
                table: "FakeTable",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<bool>(
                name: "active_bool",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "insert_by",
                schema: "fake",
                table: "FakeTable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 44, 20, 262, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "update_by",
                schema: "fake",
                table: "FakeTable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "update_date",
                schema: "fake",
                table: "FakeTable",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DTCovid2",
                schema: "dbMob",
                columns: table => new
                {
                    active_bool = table.Column<bool>(nullable: false, defaultValue: true),
                    insert_by = table.Column<string>(nullable: true),
                    insert_date = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 24, 9, 44, 20, 262, DateTimeKind.Local)),
                    update_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    EmpNo = table.Column<string>(nullable: true),
                    HPNo = table.Column<string>(nullable: true),
                    TimeCheck = table.Column<DateTime>(nullable: false),
                    Temp = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTCovid2", x => x.active_bool);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTCovid2",
                schema: "dbMob");

            migrationBuilder.DropColumn(
                name: "active_bool",
                schema: "fake",
                table: "FakeTable");

            migrationBuilder.DropColumn(
                name: "insert_by",
                schema: "fake",
                table: "FakeTable");

            migrationBuilder.DropColumn(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable");

            migrationBuilder.DropColumn(
                name: "update_by",
                schema: "fake",
                table: "FakeTable");

            migrationBuilder.DropColumn(
                name: "update_date",
                schema: "fake",
                table: "FakeTable");

            migrationBuilder.AlterColumn<string>(
                name: "UserName2",
                schema: "fake",
                table: "FakeTable",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "fake",
                table: "FakeTable",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FakeTable_UserName2",
                schema: "fake",
                table: "FakeTable",
                column: "UserName2",
                unique: true,
                filter: "[UserName2] IS NOT NULL");
        }
    }
}
