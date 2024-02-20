using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaLifeHospital.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class handlemigrationError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Comments");
        }
    }
}
