using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MirrorDB.Migrations
{
    public partial class InitialMigrationCOVId3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTCovid2",
                schema: "dbMob");

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 48, 30, 736, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 44, 20, 262, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "DTCovid",
                schema: "dbMob",
                columns: table => new
                {
                    active_bool = table.Column<bool>(nullable: false, defaultValue: true),
                    insert_by = table.Column<string>(nullable: true),
                    insert_date = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 24, 9, 48, 30, 736, DateTimeKind.Local)),
                    update_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpNo = table.Column<string>(maxLength: 100, nullable: false),
                    HPNo = table.Column<string>(maxLength: 200, nullable: false),
                    TimeCheck = table.Column<DateTime>(nullable: false),
                    Temp = table.Column<string>(maxLength: 5, nullable: false),
                    Location = table.Column<string>(maxLength: 200, nullable: true),
                    Note = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTCovid", x => x.active_bool);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DTCovid_EmpNo",
                schema: "dbMob",
                table: "DTCovid",
                column: "EmpNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DTCovid_HPNo",
                schema: "dbMob",
                table: "DTCovid",
                column: "HPNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTCovid",
                schema: "dbMob");

            migrationBuilder.AlterColumn<DateTime>(
                name: "insert_date",
                schema: "fake",
                table: "FakeTable",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 24, 9, 44, 20, 262, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 24, 9, 48, 30, 736, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "DTCovid2",
                schema: "dbMob",
                columns: table => new
                {
                    active_bool = table.Column<bool>(nullable: false, defaultValue: true),
                    EmpNo = table.Column<string>(nullable: true),
                    HPNo = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Temp = table.Column<string>(nullable: true),
                    TimeCheck = table.Column<DateTime>(nullable: false),
                    insert_by = table.Column<string>(nullable: true),
                    insert_date = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 24, 9, 44, 20, 262, DateTimeKind.Local)),
                    update_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTCovid2", x => x.active_bool);
                });
        }
    }
}
