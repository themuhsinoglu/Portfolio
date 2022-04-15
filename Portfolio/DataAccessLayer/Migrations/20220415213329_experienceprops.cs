using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class experienceprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Experiences",
                newName: "StartDate");

            migrationBuilder.AddColumn<string>(
                name: "FinishDate",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinishDate",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Experiences",
                newName: "Date");
        }
    }
}
