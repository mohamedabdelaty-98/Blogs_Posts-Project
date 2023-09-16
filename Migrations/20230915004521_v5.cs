using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task2.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_Catalog_Cat_id",
                table: "posts");

            migrationBuilder.AlterColumn<int>(
                name: "Cat_id",
                table: "posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_Catalog_Cat_id",
                table: "posts",
                column: "Cat_id",
                principalTable: "Catalog",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_Catalog_Cat_id",
                table: "posts");

            migrationBuilder.AlterColumn<int>(
                name: "Cat_id",
                table: "posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_Catalog_Cat_id",
                table: "posts",
                column: "Cat_id",
                principalTable: "Catalog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
