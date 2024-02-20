using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaLifeHospital.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class editappointmentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisitorMail",
                table: "Appointments",
                newName: "VisitorEMail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisitorEMail",
                table: "Appointments",
                newName: "VisitorMail");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
