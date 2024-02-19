using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaLifeHospital.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class edit_tagcloudentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagCloud_Blogs_BlogId1",
                table: "TagCloud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagCloud",
                table: "TagCloud");

            migrationBuilder.RenameTable(
                name: "TagCloud",
                newName: "TagsCloud");

            migrationBuilder.RenameIndex(
                name: "IX_TagCloud_BlogId1",
                table: "TagsCloud",
                newName: "IX_TagsCloud_BlogId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagsCloud",
                table: "TagsCloud",
                column: "TagCloudId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagsCloud_Blogs_BlogId1",
                table: "TagsCloud",
                column: "BlogId1",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagsCloud_Blogs_BlogId1",
                table: "TagsCloud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagsCloud",
                table: "TagsCloud");

            migrationBuilder.RenameTable(
                name: "TagsCloud",
                newName: "TagCloud");

            migrationBuilder.RenameIndex(
                name: "IX_TagsCloud_BlogId1",
                table: "TagCloud",
                newName: "IX_TagCloud_BlogId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagCloud",
                table: "TagCloud",
                column: "TagCloudId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagCloud_Blogs_BlogId1",
                table: "TagCloud",
                column: "BlogId1",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
