using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MirrorDB.Migrations
{
    public partial class InitialMigrationCOVId19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 973, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 48, 30, 736, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbMob",
                table: "DTCovid",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 48, 30, 736, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "MTEmp",
                schema: "dbMob",
                columns: table => new
                {
                    active_bool = table.Column<bool>(nullable: false, defaultValue: true),
                    insert_by = table.Column<string>(nullable: true),
                    insert_date = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local)),
                    update_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpNo = table.Column<string>(maxLength: 100, nullable: false),
                    EmpName = table.Column<string>(maxLength: 200, nullable: false),
                    HPNo = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTEmp", x => x.active_bool);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MTEmp_EmpName",
                schema: "dbMob",
                table: "MTEmp",
                column: "EmpName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MTEmp_EmpNo",
                schema: "dbMob",
                table: "MTEmp",
                column: "EmpNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MTEmp",
                schema: "dbMob");

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 48, 30, 736, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 973, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "dbMob",
                table: "DTCovid",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 48, 30, 736, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local));
        }
    }
}
