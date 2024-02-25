using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaLifeHospital.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Contact_VisitorContactEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "SendDate",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Contacts",
                newName: "ContactPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "ContactMail");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Contacts",
                newName: "ContactAddress");

            migrationBuilder.RenameColumn(
                name: "VisitorContactID",
                table: "Contacts",
                newName: "ContactId");

            migrationBuilder.CreateTable(
                name: "VisitorContacts",
                columns: table => new
                {
                    VisitorContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorContacts", x => x.VisitorContactID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitorContacts");

            migrationBuilder.RenameColumn(
                name: "ContactPhoneNumber",
                table: "Contacts",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "ContactMail",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ContactAddress",
                table: "Contacts",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contacts",
                newName: "VisitorContactID");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SendDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
