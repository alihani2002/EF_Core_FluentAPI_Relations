using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationsBookAnd_BD_P_C : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Categories Table",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookDetailsId",
                table: "Book Data",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Book Data",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Book Data",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories Table_SubCategoryId",
                table: "Categories Table",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book Data_BookDetailsId",
                table: "Book Data",
                column: "BookDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Book Data_CategoryId",
                table: "Book Data",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book Data_PublisherId",
                table: "Book Data",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book Data_Book Details Data_BookDetailsId",
                table: "Book Data",
                column: "BookDetailsId",
                principalTable: "Book Details Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book Data_Categories Table_CategoryId",
                table: "Book Data",
                column: "CategoryId",
                principalTable: "Categories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book Data_Publisher Table_PublisherId",
                table: "Book Data",
                column: "PublisherId",
                principalTable: "Publisher Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories Table_SubCategories Table_SubCategoryId",
                table: "Categories Table",
                column: "SubCategoryId",
                principalTable: "SubCategories Table",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book Data_Book Details Data_BookDetailsId",
                table: "Book Data");

            migrationBuilder.DropForeignKey(
                name: "FK_Book Data_Categories Table_CategoryId",
                table: "Book Data");

            migrationBuilder.DropForeignKey(
                name: "FK_Book Data_Publisher Table_PublisherId",
                table: "Book Data");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories Table_SubCategories Table_SubCategoryId",
                table: "Categories Table");

            migrationBuilder.DropIndex(
                name: "IX_Categories Table_SubCategoryId",
                table: "Categories Table");

            migrationBuilder.DropIndex(
                name: "IX_Book Data_BookDetailsId",
                table: "Book Data");

            migrationBuilder.DropIndex(
                name: "IX_Book Data_CategoryId",
                table: "Book Data");

            migrationBuilder.DropIndex(
                name: "IX_Book Data_PublisherId",
                table: "Book Data");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Categories Table");

            migrationBuilder.DropColumn(
                name: "BookDetailsId",
                table: "Book Data");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Book Data");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Book Data");
        }
    }
}
