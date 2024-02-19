using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaLifeHospital.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class edit2_tagCloudEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagsCloud_Blogs_BlogId1",
                table: "TagsCloud");

            migrationBuilder.DropIndex(
                name: "IX_TagsCloud_BlogId1",
                table: "TagsCloud");

            migrationBuilder.DropColumn(
                name: "BlogId1",
                table: "TagsCloud");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "TagsCloud",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_TagsCloud_BlogId",
                table: "TagsCloud",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagsCloud_Blogs_BlogId",
                table: "TagsCloud",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagsCloud_Blogs_BlogId",
                table: "TagsCloud");

            migrationBuilder.DropIndex(
                name: "IX_TagsCloud_BlogId",
                table: "TagsCloud");

            migrationBuilder.AlterColumn<string>(
                name: "BlogId",
                table: "TagsCloud",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BlogId1",
                table: "TagsCloud",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TagsCloud_BlogId1",
                table: "TagsCloud",
                column: "BlogId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TagsCloud_Blogs_BlogId1",
                table: "TagsCloud",
                column: "BlogId1",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
