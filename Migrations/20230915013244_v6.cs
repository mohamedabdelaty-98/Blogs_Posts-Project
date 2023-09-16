using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task2.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_Catalog_Cat_id",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catalog",
                table: "Catalog");

            migrationBuilder.RenameTable(
                name: "Catalog",
                newName: "catalogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catalogs",
                table: "catalogs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_catalogs_Cat_id",
                table: "posts",
                column: "Cat_id",
                principalTable: "catalogs",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_catalogs_Cat_id",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catalogs",
                table: "catalogs");

            migrationBuilder.RenameTable(
                name: "catalogs",
                newName: "Catalog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catalog",
                table: "Catalog",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_Catalog_Cat_id",
                table: "posts",
                column: "Cat_id",
                principalTable: "Catalog",
                principalColumn: "ID");
        }
    }
}
