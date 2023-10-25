using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationBetweenCategoryAndSub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories Table_SubCategories Table_SubCategoryId",
                table: "Categories Table");

            migrationBuilder.DropIndex(
                name: "IX_Categories Table_SubCategoryId",
                table: "Categories Table");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Categories Table");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Categories Table",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories Table_CategoryId",
                table: "Categories Table",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories Table_SubCategories Table_CategoryId",
                table: "Categories Table",
                column: "CategoryId",
                principalTable: "SubCategories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories Table_SubCategories Table_CategoryId",
                table: "Categories Table");

            migrationBuilder.DropIndex(
                name: "IX_Categories Table_CategoryId",
                table: "Categories Table");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories Table");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Categories Table",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories Table_SubCategoryId",
                table: "Categories Table",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories Table_SubCategories Table_SubCategoryId",
                table: "Categories Table",
                column: "SubCategoryId",
                principalTable: "SubCategories Table",
                principalColumn: "Id");
        }
    }
}
