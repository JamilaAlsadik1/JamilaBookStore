using Microsoft.EntityFrameworkCore.Migrations;

namespace JamilaBooks.DataAccess.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_coverTypes_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_coverTypes",
                table: "coverTypes");

            migrationBuilder.RenameTable(
                name: "coverTypes",
                newName: "CoverTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoverTypes",
                table: "CoverTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoverTypes_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoverTypes_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoverTypes",
                table: "CoverTypes");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                newName: "coverTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_coverTypes",
                table: "coverTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_coverTypes_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "coverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
