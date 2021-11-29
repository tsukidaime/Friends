using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class Event_PeriodicityType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WillAttend",
                table: "UserEvents");

            migrationBuilder.RenameColumn(
                name: "Periodicity",
                table: "Events",
                newName: "PeriodicityType");

            migrationBuilder.AddColumn<int>(
                name: "AttendanceType",
                table: "UserEvents",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttendanceType",
                table: "UserEvents");

            migrationBuilder.RenameColumn(
                name: "PeriodicityType",
                table: "Events",
                newName: "Periodicity");

            migrationBuilder.AddColumn<bool>(
                name: "WillAttend",
                table: "UserEvents",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
