using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flomak.com.tr.Migrations
{
    public partial class AddInitalFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlomakSectors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    SectorName = table.Column<string>(nullable: true),
                    SectorCategory = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    History = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlomakSectors", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlomakSectors");
        }
    }
}
