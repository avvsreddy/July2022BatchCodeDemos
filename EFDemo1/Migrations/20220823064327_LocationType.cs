using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemo1.Migrations
{
    public partial class LocationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Contacts",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
