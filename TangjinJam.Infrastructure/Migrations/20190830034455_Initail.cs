using Microsoft.EntityFrameworkCore.Migrations;

namespace TangjinJam.Infrastructure.Migrations
{
    public partial class Initail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ItemDetail_DetailId = table.Column<string>(nullable: true),
                    ItemDetail_Price = table.Column<string>(nullable: true),
                    ItemDetail_Brand = table.Column<string>(nullable: true),
                    ItemDetail_IsBuy = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
