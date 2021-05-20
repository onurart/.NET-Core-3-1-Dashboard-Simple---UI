using Microsoft.EntityFrameworkCore.Migrations;

namespace Flomak.com.tr.Migrations
{
    public partial class AddInitalCodeFirstv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Text1 = table.Column<string>(nullable: true),
                    Text2 = table.Column<string>(nullable: true),
                    Text3 = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
