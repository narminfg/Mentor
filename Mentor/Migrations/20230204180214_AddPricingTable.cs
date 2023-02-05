using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor.Migrations
{
    public partial class AddPricingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pricings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: false),
                    term1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    term2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    term3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    term4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    term5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pricings");
        }
    }
}
