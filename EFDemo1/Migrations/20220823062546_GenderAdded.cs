using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemo1.Migrations
{
    public partial class GenderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Contacts");
        }
    }
}
