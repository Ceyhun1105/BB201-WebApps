using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna.Migrations
{
    public partial class DivideTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Sliders",
                newName: "Title2");

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title1",
                table: "Sliders");

            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "Sliders",
                newName: "Title");
        }
    }
}
