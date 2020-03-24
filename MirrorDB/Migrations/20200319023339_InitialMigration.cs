using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MirrorDB.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "fake");

            migrationBuilder.CreateTable(
                name: "FakeTable",
                schema: "fake",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    UserName2 = table.Column<string>(nullable: true),
                    UserName3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FakeTable", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FakeTable_UserName2",
                schema: "fake",
                table: "FakeTable",
                column: "UserName2",
                unique: true,
                filter: "[UserName2] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FakeTable",
                schema: "fake");
        }
    }
}
