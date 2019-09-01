using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TangjinJam.Infrastructure.Migrations
{
    public partial class AdditionalChild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalChildItem",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ChildName = table.Column<string>(nullable: true),
                    Priority = table.Column<decimal>(nullable: false),
                    GetDateTime = table.Column<DateTime>(nullable: false),
                    IsGet = table.Column<short>(nullable: false),
                    ItemId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalChildItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalChildItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalChildItem_ItemId",
                table: "AdditionalChildItem",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalChildItem");
        }
    }
}
