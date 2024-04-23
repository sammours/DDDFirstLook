using Microsoft.EntityFrameworkCore.Migrations;

namespace DDDFirstLook.Infrastructure.Migrations
{
    public partial class FixTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Availability");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Availability");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Availability");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Availability",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Address",
                newName: "Street");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Availability",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Availability",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Availability");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Availability");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Availability",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Address",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Availability",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Availability",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Availability",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Address",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
