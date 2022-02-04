using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContainerId = table.Column<int>(nullable: false),
                    TrackingNumber = table.Column<int>(nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Courier = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Handling = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Chute = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DeliverySlip = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packages");
        }
    }
}
