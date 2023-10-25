using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryAndSub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories Table_SubCategories Table_CategoryId",
                table: "Categories Table");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories Table",
                newName: "SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories Table_CategoryId",
                table: "Categories Table",
                newName: "IX_Categories Table_SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories Table_SubCategories Table_SubCategoryId",
                table: "Categories Table",
                column: "SubCategoryId",
                principalTable: "SubCategories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories Table_SubCategories Table_SubCategoryId",
                table: "Categories Table");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Categories Table",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories Table_SubCategoryId",
                table: "Categories Table",
                newName: "IX_Categories Table_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories Table_SubCategories Table_CategoryId",
                table: "Categories Table",
                column: "CategoryId",
                principalTable: "SubCategories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
